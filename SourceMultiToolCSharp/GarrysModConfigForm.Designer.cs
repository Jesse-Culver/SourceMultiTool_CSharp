namespace SourceMultiToolCSharp
{
    partial class GarrysModConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GarrysModConfigForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listbox_gmodContent = new System.Windows.Forms.CheckedListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_gmodSave = new System.Windows.Forms.Button();
            this.button_gmodAddonsFolder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listbox_gmodContent);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Content To Mount";
            // 
            // listbox_gmodContent
            // 
            this.listbox_gmodContent.FormattingEnabled = true;
            this.listbox_gmodContent.Location = new System.Drawing.Point(6, 19);
            this.listbox_gmodContent.Name = "listbox_gmodContent";
            this.listbox_gmodContent.Size = new System.Drawing.Size(194, 229);
            this.listbox_gmodContent.Sorted = true;
            this.listbox_gmodContent.TabIndex = 0;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // button_gmodSave
            // 
            this.button_gmodSave.Location = new System.Drawing.Point(137, 275);
            this.button_gmodSave.Name = "button_gmodSave";
            this.button_gmodSave.Size = new System.Drawing.Size(75, 23);
            this.button_gmodSave.TabIndex = 2;
            this.button_gmodSave.Text = "Save";
            this.button_gmodSave.UseVisualStyleBackColor = true;
            this.button_gmodSave.Click += new System.EventHandler(this.button_gmodSave_Click);
            // 
            // button_gmodAddonsFolder
            // 
            this.button_gmodAddonsFolder.Location = new System.Drawing.Point(12, 275);
            this.button_gmodAddonsFolder.Name = "button_gmodAddonsFolder";
            this.button_gmodAddonsFolder.Size = new System.Drawing.Size(112, 23);
            this.button_gmodAddonsFolder.TabIndex = 3;
            this.button_gmodAddonsFolder.Text = "Open Addons Folder";
            this.button_gmodAddonsFolder.UseVisualStyleBackColor = true;
            this.button_gmodAddonsFolder.Click += new System.EventHandler(this.button_gmodAddonsFolder_Click);
            // 
            // GarrysModConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 306);
            this.Controls.Add(this.button_gmodAddonsFolder);
            this.Controls.Add(this.button_gmodSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GarrysModConfigForm";
            this.Text = "Garrys Mod Config";
            this.Shown += new System.EventHandler(this.GarrysModConfigForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox listbox_gmodContent;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_gmodSave;
        private System.Windows.Forms.Button button_gmodAddonsFolder;
    }
}