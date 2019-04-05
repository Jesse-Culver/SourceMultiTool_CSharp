using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SourceMultiToolCSharp
{
    public partial class GarrysModConfigForm : Form
    {
        public GarrysModConfigForm()
        {
            InitializeComponent();
        }
        Dictionary<string,string> gmodAddons = new Dictionary<string,string>();
        string gmodDirectory = "";
        private void GarrysModConfigForm_Shown(object sender, EventArgs e)
        {
            // Populate our menu with the games they have
            foreach (SourceGame game in MainMenuForm.listOfSourceGames)
            {
                if (game.Installed)
                {
                    
                    if (game.SteamName == "GarrysMod")
                    {
                        // Now we search their addons folder for folders
                        gmodDirectory = game.Directory;
                        var garrysModAddonFolders = Directory.GetDirectories(game.Directory + "/garrysmod/addons");
                        foreach (string addon in garrysModAddonFolders)
                        {
                            string addonName = "Addon: "+addon.Remove(0, game.Directory.Length + 18);
                            
                            listbox_gmodContent.Items.Add(addonName);
                            gmodAddons.Add(addonName, addon);
                        }
                    }
                    else
                    {
                        listbox_gmodContent.Items.Add(game.ProperName);
                    }
                }
            }
        }

        private void button_gmodAddonsFolder_Click(object sender, EventArgs e)
        {
            Process.Start(gmodDirectory + "/garrysmod/addons");
        }

        private void button_gmodSave_Click(object sender, EventArgs e)
        {
            //Backup the file if it exists
            if(File.Exists(gmodDirectory+"/garrysmod/cfg/mount.cfg"))
            {
                File.Copy(gmodDirectory + "/garrysmod/cfg/mount.cfg", gmodDirectory + "/garrysmod/cfg/mount.cfg.backup",true);
            }
            using (StreamWriter writer = new StreamWriter(gmodDirectory + "/garrysmod/cfg/mount.cfg"))
            {
                writer.WriteLine("// Use this file to mount additional paths to the filesystem");
                writer.WriteLine("// DO NOT add a slash to the end of the filename \n\n");
                writer.WriteLine("\"mountcfg\"");
                writer.WriteLine("{");
                foreach (string content in listbox_gmodContent.CheckedItems)
                {
                    // TODO: This could be better optimized
                    foreach (SourceGame game in MainMenuForm.listOfSourceGames)
                    {
                        if(game.ProperName == content)
                        {
                            writer.WriteLine("\""+game.SourceName+"\"    "+"\""+game.Directory+"\\"+game.SourceName+"\"");
                        }
                    }
                    if (gmodAddons.ContainsKey(content))
                    {
                        writer.WriteLine("\"" + content.Remove(0, 7) + "\"    " + "\"" + gmodAddons[content] + "\"");
                    }
                }
                writer.WriteLine("}");
                System.Windows.Forms.MessageBox.Show("WARNING: This does not auto pack this content into your map you must still do this on your own!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.Windows.Forms.MessageBox.Show("Save Complete!", "Garry's Mod Configuration Saved", MessageBoxButtons.OK);
            }
        }
    }
}
