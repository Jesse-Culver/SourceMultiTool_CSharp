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

        private class SourceGame
        {
            public string SteamName { get; set; }
            public string ProperName { get; set; }
            public bool Installed { get; set; }
            public string Directory { get; set; }
        }

        private List<string> steamDirectories = new List<string>();
        List<SourceGame> listOfSourceGames = new List<SourceGame>();

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
            // Load in saved properties if still valid
            if (File.Exists(Properties.Settings.Default.mainSteamDir + "/steamapps/libraryfolders.vdf"))
            {
                textSteamDirectory.Text = Properties.Settings.Default.mainSteamDir;
            }
            // Add Source Games
            listOfSourceGames.Add(new SourceGame {
                SteamName = "Contagion",
                ProperName = "Contagion",
                Installed = false,
                Directory = ""});
            listOfSourceGames.Add(new SourceGame { SteamName = "Counter-Strike Global Offensive",
                ProperName = "Counter-Strike Global Offensive",
                Installed = false,
                Directory = "" });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Counter-Strike Source",
                ProperName = "Counter-Strike Source",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Day of Defeat Source",
                ProperName = "Day of Defeat Source",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "dayofinfamy",
                ProperName = "Day of Infamy",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "GarrysMod",
                ProperName = "Garrys Mod",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Half-Life 2",
                ProperName = "Half-Life 2",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "insurgency2",
                ProperName = "Insurgency",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "insurgency2",
                ProperName = "Insurgency",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Left 4 Dead 2",
                ProperName = "Left 4 Dead 2",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "nmrih",
                ProperName = "No More Room In Hell",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Portal",
                ProperName = "Portal",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Portal 2",
                ProperName = "Portal 2",
                Installed = false,
                Directory = ""
            });
            listOfSourceGames.Add(new SourceGame
            {
                SteamName = "Team Fortress 2",
                ProperName = "Team Fortress 2",
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
                if(lines.Count() != 5)
                {
                    //This means we have multiple directories
                    steamDirectories.Clear();
                    steamDirectories.Add(textSteamDirectory.Text);
                    int numberOfDirectories = lines.Count() - 5;
                    for(int i = 4; i < lines.Count()-1; i++)    //start at line 5 and go to closing bracket
                    {
                        string temp = lines[i];
                        int finalPosition = temp.LastIndexOf("\"");
                        int startPosition = temp.LastIndexOf("\"", finalPosition - 1)+1;    //Dont grab the same position or starting quote
                        temp = temp.Substring(startPosition, (finalPosition - startPosition)).Replace("\\\\","\\");
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
                        game.Directory = dir + "\\steamapps\\common\\"+game.SteamName;
                        game.Installed = true;
                    }
                }
            }
            updateDebugInfo();
        }

        private void updateDebugInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (SourceGame game in listOfSourceGames)
            {
                sb.AppendLine("steamName: ");
                sb.AppendLine(game.SteamName);
                sb.AppendLine("properName: ");
                sb.AppendLine(game.ProperName);
                sb.AppendLine("installed: ");
                sb.AppendLine(game.Installed.ToString());
                if (game.Installed)
                {
                    sb.AppendLine("Directory: ");
                    sb.AppendLine(game.Directory);
                }
                sb.AppendLine("\n");
            }
            richTextBoxSourceGameDebug.Text = sb.ToString();
        }
    }
}
