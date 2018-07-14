using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceMultiToolCSharp
{
    public partial class mainMenuForm : Form
    {
        public mainMenuForm()
        {
            InitializeComponent();
        }

        private void buttonBrowseSteamDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialogSteam.ShowDialog();
            if(result == DialogResult.OK)
            {
                textSteamDirectory.Text = folderBrowserDialogSteam.SelectedPath;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(textSteamDirectory.Text+"/Steam.exe"))
            {
                Properties.Settings.Default.mainSteamDir = textSteamDirectory.Text;
                findSteamDirectories();
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("The Main Steam Directory you have chosen does not contain Steam.exe meaning it is not your main directory","ERROR 001",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void mainMenuForm_Load(object sender, EventArgs e)
        {
            textSteamDirectory.Text = Properties.Settings.Default.mainSteamDir;
        }

        private void findSteamDirectories()
        {
            if (File.Exists(textSteamDirectory.Text + "/steamapps/libraryfolders.vdf"))
            {
                string[] lines = File.ReadAllLines(textSteamDirectory.Text + "/steamapps/libraryfolders.vdf");
                richTextBoxAdditionalSteamDirectory.Text = lines[4];
            }
        }
    }
}
