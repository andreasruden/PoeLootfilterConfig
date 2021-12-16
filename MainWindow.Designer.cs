using System.Windows.Forms;

namespace PoeLootfilterConfig
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.levelingTab = new System.Windows.Forms.TabPage();
            this.levelingFilterWeaponsGroupbox = new System.Windows.Forms.GroupBox();
            this.levelingFilterWeaponsFlowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.levelingFilterArmorsGroupbox = new System.Windows.Forms.GroupBox();
            this.levelingArmorFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.levelingFilterPathBox = new System.Windows.Forms.TextBox();
            this.saveLevelingBtn = new System.Windows.Forms.Button();
            this.endgameTab = new System.Windows.Forms.TabPage();
            this.mainTabs.SuspendLayout();
            this.levelingTab.SuspendLayout();
            this.levelingFilterWeaponsGroupbox.SuspendLayout();
            this.levelingFilterArmorsGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabs.Controls.Add(this.levelingTab);
            this.mainTabs.Controls.Add(this.endgameTab);
            this.mainTabs.Location = new System.Drawing.Point(19, 20);
            this.mainTabs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(1076, 611);
            this.mainTabs.TabIndex = 0;
            // 
            // levelingTab
            // 
            this.levelingTab.BackColor = System.Drawing.Color.DimGray;
            this.levelingTab.Controls.Add(this.levelingFilterWeaponsGroupbox);
            this.levelingTab.Controls.Add(this.levelingFilterArmorsGroupbox);
            this.levelingTab.Controls.Add(this.levelingFilterPathBox);
            this.levelingTab.Controls.Add(this.saveLevelingBtn);
            this.levelingTab.Location = new System.Drawing.Point(4, 29);
            this.levelingTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.levelingTab.Name = "levelingTab";
            this.levelingTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.levelingTab.Size = new System.Drawing.Size(1068, 578);
            this.levelingTab.TabIndex = 0;
            this.levelingTab.Text = "Leveling Filter";
            // 
            // levelingFilterWeaponsGroupbox
            // 
            this.levelingFilterWeaponsGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.levelingFilterWeaponsGroupbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.levelingFilterWeaponsGroupbox.Controls.Add(this.levelingFilterWeaponsFlowlayout);
            this.levelingFilterWeaponsGroupbox.ForeColor = System.Drawing.Color.White;
            this.levelingFilterWeaponsGroupbox.Location = new System.Drawing.Point(10, 159);
            this.levelingFilterWeaponsGroupbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.levelingFilterWeaponsGroupbox.Name = "levelingFilterWeaponsGroupbox";
            this.levelingFilterWeaponsGroupbox.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.levelingFilterWeaponsGroupbox.Size = new System.Drawing.Size(1047, 361);
            this.levelingFilterWeaponsGroupbox.TabIndex = 3;
            this.levelingFilterWeaponsGroupbox.TabStop = false;
            this.levelingFilterWeaponsGroupbox.Text = "Weapons";
            // 
            // levelingFilterWeaponsFlowlayout
            // 
            this.levelingFilterWeaponsFlowlayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.levelingFilterWeaponsFlowlayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.levelingFilterWeaponsFlowlayout.Location = new System.Drawing.Point(24, 30);
            this.levelingFilterWeaponsFlowlayout.Name = "levelingFilterWeaponsFlowlayout";
            this.levelingFilterWeaponsFlowlayout.Size = new System.Drawing.Size(990, 313);
            this.levelingFilterWeaponsFlowlayout.TabIndex = 0;
            // 
            // levelingFilterArmorsGroupbox
            // 
            this.levelingFilterArmorsGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.levelingFilterArmorsGroupbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.levelingFilterArmorsGroupbox.Controls.Add(this.levelingArmorFlowLayout);
            this.levelingFilterArmorsGroupbox.ForeColor = System.Drawing.Color.White;
            this.levelingFilterArmorsGroupbox.Location = new System.Drawing.Point(10, 11);
            this.levelingFilterArmorsGroupbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.levelingFilterArmorsGroupbox.Name = "levelingFilterArmorsGroupbox";
            this.levelingFilterArmorsGroupbox.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.levelingFilterArmorsGroupbox.Size = new System.Drawing.Size(1047, 138);
            this.levelingFilterArmorsGroupbox.TabIndex = 2;
            this.levelingFilterArmorsGroupbox.TabStop = false;
            this.levelingFilterArmorsGroupbox.Text = "Armors";
            // 
            // levelingArmorFlowLayout
            // 
            this.levelingArmorFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.levelingArmorFlowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.levelingArmorFlowLayout.Location = new System.Drawing.Point(24, 30);
            this.levelingArmorFlowLayout.Name = "levelingArmorFlowLayout";
            this.levelingArmorFlowLayout.Size = new System.Drawing.Size(990, 79);
            this.levelingArmorFlowLayout.TabIndex = 0;
            // 
            // levelingFilterPathBox
            // 
            this.levelingFilterPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.levelingFilterPathBox.BackColor = System.Drawing.Color.Snow;
            this.levelingFilterPathBox.ForeColor = System.Drawing.Color.Black;
            this.levelingFilterPathBox.Location = new System.Drawing.Point(197, 530);
            this.levelingFilterPathBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.levelingFilterPathBox.Name = "levelingFilterPathBox";
            this.levelingFilterPathBox.Size = new System.Drawing.Size(699, 26);
            this.levelingFilterPathBox.TabIndex = 1;
            this.levelingFilterPathBox.Text = "<Path>";
            this.levelingFilterPathBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.levelingFilterPathBox_MouseDown);
            // 
            // saveLevelingBtn
            // 
            this.saveLevelingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveLevelingBtn.AutoSize = true;
            this.saveLevelingBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveLevelingBtn.BackColor = System.Drawing.Color.Snow;
            this.saveLevelingBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.saveLevelingBtn.Location = new System.Drawing.Point(904, 528);
            this.saveLevelingBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveLevelingBtn.Name = "saveLevelingBtn";
            this.saveLevelingBtn.Size = new System.Drawing.Size(156, 30);
            this.saveLevelingBtn.TabIndex = 0;
            this.saveLevelingBtn.Text = "Save Leveling Filter";
            this.saveLevelingBtn.UseVisualStyleBackColor = false;
            this.saveLevelingBtn.Click += new System.EventHandler(this.saveLevelingBtn_Click);
            // 
            // endgameTab
            // 
            this.endgameTab.BackColor = System.Drawing.Color.DimGray;
            this.endgameTab.Location = new System.Drawing.Point(4, 29);
            this.endgameTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endgameTab.Name = "endgameTab";
            this.endgameTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endgameTab.Size = new System.Drawing.Size(1068, 578);
            this.endgameTab.TabIndex = 1;
            this.endgameTab.Text = "Endgame Filter";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1113, 650);
            this.Controls.Add(this.mainTabs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "PoE Lootfilter Config";
            this.mainTabs.ResumeLayout(false);
            this.levelingTab.ResumeLayout(false);
            this.levelingTab.PerformLayout();
            this.levelingFilterWeaponsGroupbox.ResumeLayout(false);
            this.levelingFilterArmorsGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage levelingTab;
        private System.Windows.Forms.TabPage endgameTab;
        private System.Windows.Forms.Button saveLevelingBtn;
        private System.Windows.Forms.TextBox levelingFilterPathBox;
        private System.Windows.Forms.GroupBox levelingFilterArmorsGroupbox;
        private FlowLayoutPanel levelingArmorFlowLayout;
        private GroupBox levelingFilterWeaponsGroupbox;
        private FlowLayoutPanel levelingFilterWeaponsFlowlayout;
    }
}

