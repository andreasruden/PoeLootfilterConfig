using System.Windows.Forms;

namespace PoeLootfilterConfig
{
    partial class MainWindow
    {
        /// <summary>
        /// Add a new checkbox that the user can select. The parameter <paramref name="optionName"/> must be unique.
        /// </summary>
        /// <param name="optionName"></param>
        public void AddLevelingFilterOption(string optionName)
        {
            var checkbox = new CheckBox();
            checkbox.Text = optionName;
            checkbox.Tag = optionName;
            checkbox.Margin = new Padding(10, 10, 10, 10);
            checkbox.Dock = DockStyle.Top;
            levelingOptionsFlowLayout.Controls.Add(checkbox);
        }

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
            this.levelingFilterOptionsGroupbox = new System.Windows.Forms.GroupBox();
            this.levelingOptionsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.levelingFilterPathBox = new System.Windows.Forms.TextBox();
            this.saveLevelingBtn = new System.Windows.Forms.Button();
            this.endgameTab = new System.Windows.Forms.TabPage();
            this.mainTabs.SuspendLayout();
            this.levelingTab.SuspendLayout();
            this.levelingFilterOptionsGroupbox.SuspendLayout();
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
            this.levelingTab.Controls.Add(this.levelingFilterOptionsGroupbox);
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
            // levelingFilterOptionsGroupbox
            // 
            this.levelingFilterOptionsGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.levelingFilterOptionsGroupbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.levelingFilterOptionsGroupbox.Controls.Add(this.levelingOptionsFlowLayout);
            this.levelingFilterOptionsGroupbox.ForeColor = System.Drawing.Color.White;
            this.levelingFilterOptionsGroupbox.Location = new System.Drawing.Point(10, 11);
            this.levelingFilterOptionsGroupbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.levelingFilterOptionsGroupbox.Name = "levelingFilterOptionsGroupbox";
            this.levelingFilterOptionsGroupbox.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.levelingFilterOptionsGroupbox.Size = new System.Drawing.Size(1047, 506);
            this.levelingFilterOptionsGroupbox.TabIndex = 2;
            this.levelingFilterOptionsGroupbox.TabStop = false;
            this.levelingFilterOptionsGroupbox.Text = "Options";
            // 
            // levelingOptionsFlowLayout
            // 
            this.levelingOptionsFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.levelingOptionsFlowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.levelingOptionsFlowLayout.Location = new System.Drawing.Point(24, 30);
            this.levelingOptionsFlowLayout.Name = "levelingOptionsFlowLayout";
            this.levelingOptionsFlowLayout.Size = new System.Drawing.Size(990, 447);
            this.levelingOptionsFlowLayout.TabIndex = 0;
            // 
            // levelingFilterPathBox
            // 
            this.levelingFilterPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.levelingFilterPathBox.BackColor = System.Drawing.Color.Snow;
            this.levelingFilterPathBox.ForeColor = System.Drawing.Color.Black;
            this.levelingFilterPathBox.Location = new System.Drawing.Point(460, 530);
            this.levelingFilterPathBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.levelingFilterPathBox.Name = "levelingFilterPathBox";
            this.levelingFilterPathBox.Size = new System.Drawing.Size(436, 26);
            this.levelingFilterPathBox.TabIndex = 1;
            this.levelingFilterPathBox.Text = "<Path>";
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
            this.levelingFilterOptionsGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage levelingTab;
        private System.Windows.Forms.TabPage endgameTab;
        private System.Windows.Forms.Button saveLevelingBtn;
        private System.Windows.Forms.TextBox levelingFilterPathBox;
        private System.Windows.Forms.GroupBox levelingFilterOptionsGroupbox;
        private FlowLayoutPanel levelingOptionsFlowLayout;
    }
}

