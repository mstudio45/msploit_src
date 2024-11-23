using MSploitRecode.Classes;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSploitRecode.Forms.synapse_ui
{
    public struct Script
    {
        public string Name;
        public string Description;
        public string ImageURL;
        public string ScriptData;
        public bool OfficialScript;
        public string DiscordInvite;

        public Script(string name, string desc, string imageurl, string scriptdata, bool officialscript, string discordInvite)
        {
            Name = name;
            Description = desc;
            ImageURL = imageurl; 
            ScriptData = scriptdata;
            OfficialScript = officialscript;
            DiscordInvite = discordInvite;
        }
    }

    public partial class Synapse_ScriptHub : Form
    {
        Dictionary<String, Script> script_array = new Dictionary<String, Script>();
        Dictionary<String, String> custom_script_loaded = new Dictionary<String, String>();
        Dictionary<String, MemoryStream> imageStreams = new Dictionary<String, MemoryStream>();

        private Fade fade;
        private TopMost topMost;

        public Synapse_ScriptHub()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(Program.OnFromLoaded);
            this.FormClosed += Program.OnFromClosed;

            new Drag(this, this.TopBar);
            fade = new Fade(this);
            topMost = new TopMost(this);
        }

        // Top Bar //
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // On Change //
        private void ScriptList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ScriptList.SelectedIndex == -1) return;
            
            string key = this.ScriptList.SelectedItem.ToString();
            if (!script_array.ContainsKey(key)) return;
        
            Script scriptData = script_array[key];
            img_.Image = null;
            info_.Text = scriptData.Description;

            Task.Run(() =>
            {
                if (string.IsNullOrEmpty(scriptData.ImageURL)) return;                    try
                {
                    if (imageStreams.ContainsKey(scriptData.ImageURL) && imageStreams[scriptData.ImageURL] != null)
                    {
                        img_.Image = Bitmap.FromStream(imageStreams[scriptData.ImageURL]);
                        return;
                    }

                    using (WebClient wc = new WebClient())
                    {
                        byte[] data = wc.DownloadData(new Uri(scriptData.ImageURL));
                        using (var stream = new System.IO.MemoryStream(data))
                        {
                            imageStreams[scriptData.ImageURL] = stream;
                            if (info_.Text == scriptData.Description)
                                img_.Image = Bitmap.FromStream(stream);
                        }
                    }
                } catch (Exception ex) { Console.WriteLine(ex); }
            });
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            if (this.ScriptList.SelectedIndex == -1) return;

            string key = this.ScriptList.SelectedItem.ToString();
            if (!script_array.ContainsKey(key)) return;

            topMost.Disable();

            Script scriptData = script_array[key];
            if (scriptData.DiscordInvite != "") Process.Start("https://discord.gg/" + scriptData.DiscordInvite);
            var execute = Data.injectorMain.Execute(scriptData.ScriptData);
            if (!execute.success)
                topMost.MessageBoxShow(execute.message, "Synapse X - v" + Synapse_INFO.VERSION, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            
            topMost.Enable();
        }

        // Load //
        private void Synapse_ScriptHub_Load(object sender, EventArgs e)
        {
            ScriptList.Items.Clear();

            script_array["mspaint"] = new Script(
                "mspaint",
                "mspaint is a free open sourced script hub. discord.gg/mspaint",
                "https://mspaint.upio.dev/favicon.ico",
                "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/notpoiu/mspaint/main/main.lua\"))()",
                true,
                ""
            );

            script_array["sUNC"] = new Script(
                "sUNC",
                "An fork of UNC that exposes fake functions and have detection for faked UNC.",
                "",
                "loadstring(game:HttpGet(\"https://gitlab.com/sens3/nebunu/-/raw/main/HummingBird8's_sUNC_yes_i_moved_to_gitlab_because_my_github_acc_got_brickedd/sUNCm0m3n7.lua\"))()",
                true,
                ""
            );

            script_array["UNC"] = new Script(
                "UNC",
                "[Discontinued] Official Unified Naming Convention.",
                "",
                "loadstring(game:HttpGet(\"https://github.com/unified-naming-convention/NamingStandard/blob/main/UNCCheckEnv.lua\"))()",
                true,
                ""
            );

            script_array["Infinite Yield"] = new Script(
                "Infinite Yield",
                "Infinite Yield is an open-source admin commands script created by Edge, Zwolf, and Moon.",
                "https://msploit.mstudio45.com/images/IY.png",
                "loadstring(game:HttpGet('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'))()",
                true,
                ""
            );

            script_array["Dark Dex"] = new Script(
                "Dark Dex",
                "A version of the popular Dex explorer with patches specifically for Synapse X.",
                "https://msploit.mstudio45.com/images/DarkDex.png",
                "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/infyiff/backup/main/dex.lua\"))()",
                true,
                ""
            );

            script_array["Simple Spy"] = new Script(
                "Simple Spy",
                "Simplified version of Remote Spy.",
                "https://raw.githubusercontent.com/exxtremestuffs/SimpleSpySource/master/assets/example-1.png",
                "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/infyiff/backup/main/SimpleSpyV3/main.lua\"))()",
                true,
                ""
            );

            script_array["Hydroxide"] = new Script(
                "Hydroxide",
                "General purpose pen-testing tool for games on the Roblox engine. This is an modern Remote Spy, Closure Spy, Upvalue/Constant/Script/Module scanner.",
                "https://raw.githubusercontent.com/Upbolt/Hydroxide/revision/github-assets/ui.png",
                "local a=\"Upbolt\"local b=\"revision\"local function c(d)return loadstring(game:HttpGetAsync((\"https://raw.githubusercontent.com/%s/Hydroxide/%s/%s.lua\"):format(a,b,d)),d..'.lua')()end;c(\"init\")c(\"ui/main\")",
                true,
                ""
            );

            script_array["Cmd X"] = new Script(
                "Cmd X",
                "A admin script with over 600 commands.",
                string.Empty,
                "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/CMD-X/CMD-X/master/Source\", true))()",
                true,
                ""
            );

            foreach (Script scriptdata in script_array.Values)
            {
                if (!ScriptList.Items.Contains(scriptdata.Name))
                    ScriptList.Items.Add(scriptdata.Name);
            }
        }
    }
}
