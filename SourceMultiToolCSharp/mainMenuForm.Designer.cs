namespace SourceMultiToolCSharp
{
    partial class mainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenuForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolsPage = new System.Windows.Forms.TabPage();
            this.buttonModelViewer = new System.Windows.Forms.Button();
            this.buttonHammer = new System.Windows.Forms.Button();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.button_gmodConfig = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.richTextBoxAdditionalSteamDirectory = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBrowseSteamDir = new System.Windows.Forms.Button();
            this.textSteamDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageDebug = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBoxSourceGameDebug = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGames = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialogSteam = new System.Windows.Forms.FolderBrowserDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.toolsPage.SuspendLayout();
            this.settingsPage.SuspendLayout();
            this.tabPageDebug.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.toolsPage);
            this.tabControl1.Controls.Add(this.settingsPage);
            this.tabControl1.Controls.Add(this.tabPageDebug);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(507, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // toolsPage
            // 
            this.toolsPage.Controls.Add(this.buttonModelViewer);
            this.toolsPage.Controls.Add(this.buttonHammer);
            this.toolsPage.Location = new System.Drawing.Point(4, 22);
            this.toolsPage.Name = "toolsPage";
            this.toolsPage.Padding = new System.Windows.Forms.Padding(3);
            this.toolsPage.Size = new System.Drawing.Size(499, 410);
            this.toolsPage.TabIndex = 0;
            this.toolsPage.Text = "Tools";
            this.toolsPage.UseVisualStyleBackColor = true;
            // 
            // buttonModelViewer
            // 
            this.buttonModelViewer.Location = new System.Drawing.Point(6, 35);
            this.buttonModelViewer.Name = "buttonModelViewer";
            this.buttonModelViewer.Size = new System.Drawing.Size(117, 23);
            this.buttonModelViewer.TabIndex = 1;
            this.buttonModelViewer.Text = "Model Viewer";
            this.buttonModelViewer.UseVisualStyleBackColor = true;
            this.buttonModelViewer.Click += new System.EventHandler(this.buttonModelViewer_Click);
            // 
            // buttonHammer
            // 
            this.buttonHammer.Location = new System.Drawing.Point(6, 6);
            this.buttonHammer.Name = "buttonHammer";
            this.buttonHammer.Size = new System.Drawing.Size(117, 23);
            this.buttonHammer.TabIndex = 0;
            this.buttonHammer.Text = "Hammer Editor";
            this.buttonHammer.UseVisualStyleBackColor = true;
            this.buttonHammer.Click += new System.EventHandler(this.buttonHammer_Click);
            // 
            // settingsPage
            // 
            this.settingsPage.Controls.Add(this.label7);
            this.settingsPage.Controls.Add(this.button_gmodConfig);
            this.settingsPage.Controls.Add(this.label5);
            this.settingsPage.Controls.Add(this.buttonSave);
            this.settingsPage.Controls.Add(this.richTextBoxAdditionalSteamDirectory);
            this.settingsPage.Controls.Add(this.label3);
            this.settingsPage.Controls.Add(this.buttonBrowseSteamDir);
            this.settingsPage.Controls.Add(this.textSteamDirectory);
            this.settingsPage.Controls.Add(this.label2);
            this.settingsPage.Location = new System.Drawing.Point(4, 22);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsPage.Size = new System.Drawing.Size(499, 410);
            this.settingsPage.TabIndex = 1;
            this.settingsPage.Text = "Settings";
            this.settingsPage.UseVisualStyleBackColor = true;
            // 
            // button_gmodConfig
            // 
            this.button_gmodConfig.Enabled = false;
            this.button_gmodConfig.Location = new System.Drawing.Point(11, 129);
            this.button_gmodConfig.Name = "button_gmodConfig";
            this.button_gmodConfig.Size = new System.Drawing.Size(180, 23);
            this.button_gmodConfig.TabIndex = 7;
            this.button_gmodConfig.Text = "Garry\'s Mod Hammer Configuration";
            this.button_gmodConfig.UseVisualStyleBackColor = true;
            this.button_gmodConfig.Click += new System.EventHandler(this.button_gmodConfig_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(461, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Before you can use the tool you need to select your main steam directory and save" +
    " your settings.";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(418, 381);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // richTextBoxAdditionalSteamDirectory
            // 
            this.richTextBoxAdditionalSteamDirectory.Location = new System.Drawing.Point(11, 59);
            this.richTextBoxAdditionalSteamDirectory.Name = "richTextBoxAdditionalSteamDirectory";
            this.richTextBoxAdditionalSteamDirectory.ReadOnly = true;
            this.richTextBoxAdditionalSteamDirectory.Size = new System.Drawing.Size(482, 51);
            this.richTextBoxAdditionalSteamDirectory.TabIndex = 4;
            this.richTextBoxAdditionalSteamDirectory.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Additional Steam Directories";
            // 
            // buttonBrowseSteamDir
            // 
            this.buttonBrowseSteamDir.Location = new System.Drawing.Point(418, 6);
            this.buttonBrowseSteamDir.Name = "buttonBrowseSteamDir";
            this.buttonBrowseSteamDir.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseSteamDir.TabIndex = 2;
            this.buttonBrowseSteamDir.Text = "Browse";
            this.buttonBrowseSteamDir.UseVisualStyleBackColor = true;
            this.buttonBrowseSteamDir.Click += new System.EventHandler(this.buttonBrowseSteamDir_Click);
            // 
            // textSteamDirectory
            // 
            this.textSteamDirectory.Location = new System.Drawing.Point(122, 7);
            this.textSteamDirectory.Name = "textSteamDirectory";
            this.textSteamDirectory.Size = new System.Drawing.Size(290, 20);
            this.textSteamDirectory.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Main Steam Directory";
            // 
            // tabPageDebug
            // 
            this.tabPageDebug.Controls.Add(this.label6);
            this.tabPageDebug.Controls.Add(this.richTextBoxSourceGameDebug);
            this.tabPageDebug.Controls.Add(this.label4);
            this.tabPageDebug.Location = new System.Drawing.Point(4, 22);
            this.tabPageDebug.Name = "tabPageDebug";
            this.tabPageDebug.Size = new System.Drawing.Size(499, 410);
            this.tabPageDebug.TabIndex = 2;
            this.tabPageDebug.Text = "Debug";
            this.tabPageDebug.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Version: 2.0.0";
            // 
            // richTextBoxSourceGameDebug
            // 
            this.richTextBoxSourceGameDebug.Location = new System.Drawing.Point(6, 26);
            this.richTextBoxSourceGameDebug.Name = "richTextBoxSourceGameDebug";
            this.richTextBoxSourceGameDebug.ReadOnly = true;
            this.richTextBoxSourceGameDebug.Size = new System.Drawing.Size(490, 96);
            this.richTextBoxSourceGameDebug.TabIndex = 1;
            this.richTextBoxSourceGameDebug.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Source Game Objects";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game/Mod";
            // 
            // comboBoxGames
            // 
            this.comboBoxGames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGames.FormattingEnabled = true;
            this.comboBoxGames.Location = new System.Drawing.Point(133, 454);
            this.comboBoxGames.Name = "comboBoxGames";
            this.comboBoxGames.Size = new System.Drawing.Size(382, 21);
            this.comboBoxGames.TabIndex = 2;
            // 
            // folderBrowserDialogSteam
            // 
            this.folderBrowserDialogSteam.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(467, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "WARNING: This does not auto pack content into your map. You still need to do that" +
    " on your own!";
            // 
            // mainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 486);
            this.Controls.Add(this.comboBoxGames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainMenuForm";
            this.Text = "Source MultiTool";
            this.Load += new System.EventHandler(this.mainMenuForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.toolsPage.ResumeLayout(false);
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
            this.tabPageDebug.ResumeLayout(false);
            this.tabPageDebug.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage toolsPage;
        private System.Windows.Forms.TabPage settingsPage;
        private System.Windows.Forms.Button buttonModelViewer;
        private System.Windows.Forms.Button buttonHammer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGames;
        private System.Windows.Forms.RichTextBox richTextBoxAdditionalSteamDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBrowseSteamDir;
        private System.Windows.Forms.TextBox textSteamDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSteam;
        private System.Windows.Forms.TabPage tabPageDebug;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxSourceGameDebug;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_gmodConfig;
        private System.Windows.Forms.Label label7;
    }
}