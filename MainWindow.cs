using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PoeLootfilterConfig
{
    public partial class MainWindow : Form
    {
        private List<Dictionary<string, string>> itemBases;

        public MainWindow()
        {
            InitializeComponent();

            AddLevelingOptions();
        }

        /// <summary>
        /// Add a new checkbox that the user can select. The parameter <paramref name="optionName"/> must be unique.
        /// </summary>
        /// <param name="optionName"></param>
        public void AddLevelingFilterOption(string optionName, bool armor)
        {
            var checkbox = new CheckBox();
            checkbox.Text = optionName;
            checkbox.Tag = optionName;
            checkbox.Margin = new Padding(10, 10, 10, 10);
            checkbox.Dock = DockStyle.Top;
            checkbox.AutoSize = true;
            if (armor)
                levelingArmorFlowLayout.Controls.Add(checkbox);
            else
                levelingFilterWeaponsFlowlayout.Controls.Add(checkbox);
        }

        private void levelingFilterPathBox_MouseDown(object sender, MouseEventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\My Games\Path of Exile";
                Console.WriteLine(dialog.InitialDirectory);
                dialog.Filter = "Lootfilters (*.filter)|*.filter|All files (*.*)|*.*";
                dialog.FilterIndex = 0;
                dialog.AutoUpgradeEnabled = true;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                    levelingFilterPathBox.Text = dialog.FileName;
            }
        }

        private void saveLevelingBtn_Click(object sender, EventArgs e)
        {
            var filepath = levelingFilterPathBox.Text;
            var source = @".\config_defaults\leveling.filter";

            if (!File.Exists(filepath))
            {
                MessageBox.Show("Could not find target file");
                return;
            }

            if (!File.Exists(source))
            {
                MessageBox.Show("Could not find filter template");
                return;
            }

            var filter = File.ReadAllText(source);

            var armorRules = BuildLevelingArmorRules();
            filter = filter.Replace("{{LEVELING_ARMOR}}", armorRules);

            var weaponRules = BuildLevelingWeaponRules();
            filter = filter.Replace("{{LEVELING_WEAPONS}}", weaponRules);

            File.WriteAllText(filepath, filter);
            MessageBox.Show("Saved Leveling Filter to " + filepath);
        }

        private void AddLevelingOptions()
        {
            var basesRaw = File.ReadAllText(@".\data\bases.json");
            itemBases = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(basesRaw);
            var armorAttributeTypes = new HashSet<string>();
            var weaponTypes = new HashSet<string>();
            foreach (var item in itemBases)
            {
                if (item["Category"] == "Armour")
                    armorAttributeTypes.Add(item["AttributeType"]);
                else
                    weaponTypes.Add(item["BaseType"]);
            }

            foreach (var attrType in armorAttributeTypes)
                AddLevelingFilterOption(attrType, true);

            foreach (var weaponType in weaponTypes)
                AddLevelingFilterOption(weaponType, false);
        }

        private string BuildLevelingArmorRules()
        {
            // XXX: Load rule template from json config

            string rules = "";
            foreach (var item in itemBases)
            {
                if (item["Category"] != "Armour")
                    continue;

                bool shouldShow = false;
                foreach (CheckBox checkbox in levelingArmorFlowLayout.Controls)
                {
                    if (checkbox.Text == item["AttributeType"] && checkbox.Checked)
                    {
                        shouldShow = true;
                        break;
                    }
                }

                if (!shouldShow)
                    continue;

                rules += "Show\n";
                rules += "    BaseType \"" + item["Name"] + "\"\n";
                rules += "    Rarity Rare\n";
                int ilvl = int.Parse(item["Level"]);
                if (ilvl < 60)
                    rules += "    ItemLevel <= " + (ilvl + 12).ToString() + "\n";
                rules += "    FontSize 45\n";
                rules += "    MinimapIcon 1 Yellow Kite\n";
            }

            return rules;
        }

        private string BuildLevelingWeaponRules()
        {
            // XXX: Load rule template from json config

            string rules = "";
            foreach (var item in itemBases)
            {
                if (item["Category"] != "Weapons")
                    continue;

                bool shouldShow = false;
                foreach (CheckBox checkbox in levelingFilterWeaponsFlowlayout.Controls)
                {
                    if (checkbox.Text == item["BaseType"] && checkbox.Checked)
                    {
                        shouldShow = true;
                        break;
                    }
                }

                if (!shouldShow)
                    continue;

                rules += "Show\n";
                rules += "    BaseType \"" + item["Name"] + "\"\n";
                int ilvl = int.Parse(item["Level"]);
                if (ilvl < 60)
                    rules += "    ItemLevel <= " + (ilvl + 10).ToString() + "\n";
                rules += "    FontSize 45\n";
                rules += "    MinimapIcon 1 Yellow Kite\n";
            }

            return rules;
        }
    }
}
