using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private class SourceGame
        {
            public string SteamName { get; set; }
            public string ProperName { get; set; }
            public string SourceName { get; set; }
            public bool Installed { get; set; }
            public string Directory { get; set; }
        }

        private List<string> steamDirectories = new List<string>();
        List<SourceGame> listOfSourceGames = new List<SourceGame>();

        private void buttonBrowseSteamDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialogSteam.ShowDialog();
            if (result == DialogResult.OK)
            {
                textSteamDirectory.Text = folderBrowserDialogSteam.SelectedPath;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(textSteamDirectory.Text + "/Steam.exe"))
            {
                Properties.Settings.Default.mainSteamDir = textSteamDirectory.Text;
                findSteamDirectories();
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("The Main Steam Directory you have chosen does not contain Steam.exe meaning it is not your main directory", "ERROR 001", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mainMenuForm_Load(object sender, EventArgs e)
        {
            // Load in saved properties if still valid
            if (File.Exists(Properties.Settings.Default.mainSteamDir + "/steamapps/libraryfolders.vdf"))
            {
                textSteamDirectory.Text = Properties.Settings.Default.mainSteamDir;
            }
            // Add Source Games
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Alien Swarm",
                ProperName = "Alien Swarm",
                SourceName = "swarm",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Contagion",
                ProperName = "Contagion",
                SourceName = "contagion",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Counter-Strike Global Offensive",
                ProperName = "Counter-Strike Global Offensive",
                SourceName = "csgo",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Counter-Strike Source",
                ProperName = "Counter-Strike Source",
                SourceName = "cstrike",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Day of Defeat Source",
                ProperName = "Day of Defeat Source",
                SourceName = "dod",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "dayofinfamy",
                ProperName = "Day of Infamy",
                SourceName = "doi",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Dino D-Day",
                ProperName = "Dino D-Day",
                SourceName = "dinodday",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Double Action",
                ProperName = "Double Action",
                SourceName = "dab",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Empires",
                ProperName = "Empires",
                SourceName = "empires",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "GarrysMod",
                ProperName = "Garrys Mod",
                SourceName = "garrysmod",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Half-Life 1 Source Deathmatch",
                ProperName = "Half-Life Source Deathmatch",
                SourceName = "hl1mp",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Half-Life 2",
                ProperName = "Half-Life 2",
                SourceName = "hl2",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Half-Life 2 Deathmatch",
                ProperName = "Half-Life 2 Deathmatch",
                SourceName = "hl2mp",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "insurgency2",
                ProperName = "Insurgency",
                SourceName = "insurgency",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Left 4 Dead 2",
                ProperName = "Left 4 Dead 2",
                SourceName = "left4dead2",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "nmrih",
                ProperName = "No More Room In Hell",
                SourceName = "nmrih",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Nuclear Dawn",
                ProperName = "Nuclear Dawn",
                SourceName = "nucleardawn",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "pirates, vikings and knights ii",
                ProperName = "Pirates, Vikings, and Knights II",
                SourceName = "pvkii",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Portal",
                ProperName = "Portal",
                SourceName = "portal",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Portal 2",
                ProperName = "Portal 2",
                SourceName = "portal2",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Team Fortress 2",
                ProperName = "Team Fortress 2",
                SourceName = "tf",
                Installed = false,
                Directory = ""
            });
            findSteamDirectories();
        }

        private void findSteamDirectories()
        {
            if (File.Exists(textSteamDirectory.Text + "/steamapps/libraryfolders.vdf"))
            {
                string[] lines = File.ReadAllLines(textSteamDirectory.Text + "/steamapps/libraryfolders.vdf");
                if (lines.Count() != 5)
                {
                    //This means we have multiple directories
                    steamDirectories.Clear();
                    steamDirectories.Add(textSteamDirectory.Text);
                    int numberOfDirectories = lines.Count() - 5;
                    for (int i = 4; i < lines.Count() - 1; i++)    //start at line 5 and go to closing bracket
                    {
                        string temp = lines[i];
                        int finalPosition = temp.LastIndexOf("\"");
                        int startPosition = temp.LastIndexOf("\"", finalPosition - 1) + 1;    //Dont grab the same position or starting quote
                        temp = temp.Substring(startPosition, (finalPosition - startPosition)).Replace("\\\\", "\\");
                        steamDirectories.Add(temp);
                    }
                    richTextBoxAdditionalSteamDirectory.Lines = steamDirectories.ToArray();
                }
            }
            checkGamesInstalled();
        }

        private void checkGamesInstalled()
        {
            // Cycle through all directories and store games we have and their locations
            foreach (string dir in steamDirectories)
            {
                foreach (SourceGame game in listOfSourceGames)
                {
                    if (Directory.Exists(dir + "\\steamapps\\common\\" + game.SteamName))
                    {
                        game.Directory = dir + "\\steamapps\\common\\" + game.SteamName;
                        game.Installed = true;
                    }
                }
            }
            updateGameDropDown();
            updateDebugInfo();
        }

        private void updateDebugInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (SourceGame game in listOfSourceGames)
            {
                sb.Append("SteamName: ");
                sb.AppendLine(game.SteamName);
                sb.Append("ProperName: ");
                sb.AppendLine(game.ProperName);
                sb.Append("SourceName: ");
                sb.AppendLine(game.SourceName);
                sb.Append("Installed: ");
                sb.AppendLine(game.Installed.ToString());
                if (game.Installed)
                {
                    sb.Append("Directory: ");
                    sb.AppendLine(game.Directory);
                }
                sb.AppendLine("\n");
            }
            richTextBoxSourceGameDebug.Text = sb.ToString();
        }

        private void updateGameDropDown()
        {
            // Clear the combobox and disable buttons
            comboBoxGames.Items.Clear();
            buttonHammer.Enabled = false;
            foreach (SourceGame game in listOfSourceGames)
            {
                if (game.Installed)
                {
                    comboBoxGames.Items.Add(game.ProperName);
                }
            }
            if (comboBoxGames.Items.Count > 0)
            {
                comboBoxGames.SelectedIndex = 0;
                // Reenable
                buttonHammer.Enabled = true;
                buttonModelViewer.Enabled = true;
            }
        }

        private void buttonHammer_Click(object sender, EventArgs e)
        {
            string gameName = comboBoxGames.GetItemText(comboBoxGames.SelectedItem);
            string directory = listOfSourceGames.First(item => item.ProperName == gameName).Directory;
            if (!File.Exists(directory + "\\bin\\hammer.exe"))
            {
                switch (gameName)
                {
                    case "Alien Swarm":
                    case "Counter-Strike Global Offensive":
                    case "Dino D-Day":
                    case "Left 4 Dead 2":
                    case "Nuclear Dawn":
                    case "Portal 2":
                        MessageBox.Show(String.Format("No Hammer install could be found at {0}\\bin\\hammer.exe \n\n Make sure you have installed it's authoring tools in Steam!", directory), "ERROR 002", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    case "No More Room In Hell":
                        if (!File.Exists(directory + "\\sdk\\bin\\hammer.exe"))
                        {
                            MessageBox.Show(String.Format("No Hammer install could be found at {0}\\sdk\\bin\\hammer.exe", directory), "ERROR 002", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                    case "Pirates, Vikings, and Knights II":
                        if (!File.Exists(directory + "\\sdkbase_pvkii\\bin\\hammer.exe"))
                        {
                            MessageBox.Show(String.Format("No Hammer install could be found at {0}\\sdkbase_pvkii\\bin\\hammer.exe", directory), "ERROR 002", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show(String.Format("No Hammer install could be found at {0}\\bin\\hammer.exe", directory), "ERROR 002", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

            }
            Process hammer = new Process();
            hammer.StartInfo.FileName = "CMD.exe";
            if (gameName == "No More Room In Hell")
                hammer.StartInfo.Arguments = "/c cd /d " + directory + "\\sdk\\bin && start \"\" hammer.exe -nop4";
            else if (gameName == "Pirates, Vikings, and Knights II")
                hammer.StartInfo.Arguments = "/c cd /d " + directory + "\\sdkbase_pvkii\\bin && start \"\" hammer.exe -nop4";
            else
                hammer.StartInfo.Arguments = "/c cd /d " + directory + "\\bin && start \"\" hammer.exe -nop4";
            hammer.Start();
        }

        private void buttonModelViewer_Click(object sender, EventArgs e)
        {
            string gameName = comboBoxGames.GetItemText(comboBoxGames.SelectedItem);
            string directory = listOfSourceGames.First(item => item.ProperName == gameName).Directory;
            string sourcename = listOfSourceGames.First(item => item.ProperName == gameName).SourceName;
            if (!File.Exists(directory + "\\bin\\hlmv.exe"))
            {
                switch (gameName)
                {
                    case "Alien Swarm":
                    case "Counter-Strike Global Offensive":
                    case "Dino D-Day":
                    case "Left 4 Dead 2":
                    case "Nuclear Dawn":
                    case "Portal 2":
                        MessageBox.Show(String.Format("No Hammer install could be found at {0}\\bin\\hlmv.exe \n\n Make sure you have installed it's authoring tools in Steam!", directory), "ERROR 003", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    case "No More Room In Hell":
                        if (!File.Exists(directory + "\\sdk\\bin\\hlmv.exe"))
                        {
                            MessageBox.Show(String.Format("No Hammer install could be found at {0}\\sdk\\bin\\hlmv.exe", directory), "ERROR 003", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                    case "Pirates, Vikings, and Knights II":
                        if (!File.Exists(directory + "\\sdkbase_pvkii\\bin\\hlmv.exe"))
                        {
                            MessageBox.Show(String.Format("No Hammer install could be found at {0}\\sdkbase_pvkii\\bin\\hlmv.exe", directory), "ERROR 003", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show(String.Format("No Hammer install could be found at {0}\\bin\\hlmv.exe", directory), "ERROR 003", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }
            }

            Process modelviewer = new Process();
            modelviewer.StartInfo.FileName = "CMD.exe";
            if (gameName == "No More Room In Hell")
                modelviewer.StartInfo.Arguments = "/c cd /d " + directory + "\\sdk\\bin && start \"\" hlmv.exe -game \"" + directory + "\\" + sourcename + "\"";
            else if (gameName == "Pirates, Vikings, and Knights II")
                modelviewer.StartInfo.Arguments = "/c cd /d " + directory + "\\sdkbase_pvkii\\bin && start \"\" hlmv.exe -game \"" + directory + "\\" + sourcename + "\"";
            else
                modelviewer.StartInfo.Arguments = "/c cd /d " + directory + "\\bin && start \"\" hlmv.exe -game \""+directory+"\\"+sourcename+"\"";
            modelviewer.Start();
        }
    }
}
