using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using MSploitRecode.Classes;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel;
using MSploitRecode.Forms.synapse_ui;
using System.Collections.Generic;
using System.Drawing;

namespace MSploitRecode.Forms.krnl_ui
{
    public partial class KRNL_MainForm : Form
    {
        private Fade fade;
        private TopMost topMost;
        Dictionary<String, Script> script_array = new Dictionary<String, Script>();

        public KRNL_MainForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(Program.OnFromLoaded);
            this.FormClosed += Program.OnFromClosed;

            new Drag(this, this.TopBar);
            fade = new Fade(this);
            topMost = new TopMost(this);
        }

        // Top Bar //
        private async void Close_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Data.TabsFolder)) Directory.CreateDirectory(Data.TabsFolder);

            for (int i = 0; i < IDETabs.TabCount; i++)
            {
                try
                {
                    IDETabs.SelectedIndex = i;
                    WebView2 webView = IDETabs.SelectedTab.Controls.OfType<WebView2>().FirstOrDefault();
                    string tab_data = await GetText(webView);

                    if (!string.IsNullOrEmpty(tab_data))
                        File.WriteAllText(Path.Combine(Data.TabsFolder, IDETabs.SelectedTab.Text + ".msploit"), tab_data);
                }
                catch { }
            }

            Program.bootstrapper.Close();
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Tabs //
        private async Task<string> GetText()
        {
            WebView2 webView = IDETabs.SelectedTab.Controls.OfType<WebView2>().FirstOrDefault();
            if (webView == null) return "";

            string rawText = await webView.ExecuteScriptAsync("GetText()");
            rawText = rawText.ToString();
            rawText = Regex.Unescape(rawText);

            if (rawText.Length >= 2 && rawText.StartsWith("\"") && rawText.EndsWith("\""))
            {
                string cleanedText = rawText.Substring(1, rawText.Length - 2);
                return cleanedText;
            }

            return rawText;
        }

        private async Task<string> GetText(WebView2 webView)
        {
            string rawText = await webView.ExecuteScriptAsync("GetText()");
            rawText = rawText.ToString();
            rawText = Regex.Unescape(rawText);

            if (rawText.Length >= 2 && rawText.StartsWith("\"") && rawText.EndsWith("\""))
            {
                string cleanedText = rawText.Substring(1, rawText.Length - 2);
                return cleanedText;
            }

            return rawText;
        }

        private async void SetText(string newText)
        {
            WebView2 webView = IDETabs.SelectedTab.Controls.OfType<WebView2>().FirstOrDefault();
            if (webView == null) return;

            JObject json = new JObject(new JProperty("msg", newText));
            string setTextData = JsonConvert.SerializeObject(json);
            setTextData = setTextData.Replace("{\"msg\":", "");
            setTextData = setTextData.Remove(setTextData.Length - 1, 1);

            await webView.CoreWebView2.ExecuteScriptAsync($"SetText({setTextData})");
        }

        private async void SetText(WebView2 webView, string newText)
        {
            JObject json = new JObject(new JProperty("msg", newText));
            string setTextData = JsonConvert.SerializeObject(json);
            setTextData = setTextData.Replace("{\"msg\":", "");
            setTextData = setTextData.Remove(setTextData.Length - 1, 1);

            await webView.CoreWebView2.ExecuteScriptAsync($"SetText({setTextData})");
        }

        private async Task EnsureWebView(WebView2 webView)
        {
            try
            {
                CoreWebView2Environment cwv2Environment = await CoreWebView2Environment.CreateAsync(null, Data.BinFolder, new CoreWebView2EnvironmentOptions());
                await webView.EnsureCoreWebView2Async(cwv2Environment);
            }
            catch (COMException ex)
            {
                topMost.MessageBoxShow($"Error initializing WebView2: {ex.Message}", "MSPLOIT");
            }
            catch (Exception ex)
            {
                topMost.MessageBoxShow($"An unexpected error occurred: {ex.Message}", "MSPLOIT");
            }
        }

        public async void InitializeWebView(string setText)
        {
            WebView2 webView = IDETabs.SelectedTab.Controls.OfType<WebView2>().FirstOrDefault();
            if (webView == null) return;

            await EnsureWebView(webView);

            webView.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            webView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            webView.CoreWebView2.Navigate("file:///" + AppDomain.CurrentDomain.BaseDirectory + "/ms_bin/IDE/KRNL/Monaco.html");
            webView.NavigationCompleted += (s, e) =>
            {
                SetText(webView, setText);
            };
        }

        public async void InitializeWebView(WebView2 webView, string setText)
        {
            await EnsureWebView(webView);

            webView.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            webView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            webView.CoreWebView2.Navigate("file:///" + AppDomain.CurrentDomain.BaseDirectory + "/ms_bin/IDE/KRNL/Monaco.html");
            webView.NavigationCompleted += (s, e) =>
            {
                SetText(webView, setText);
            };
        }

        private void AddNewTab(string text, string name, string tabText)
        {
            Data.TotalTabs += 1;

            TabPage tabPage = new TabPage();
            tabPage.AutoScroll = true;

            // Text //
            string finalTabText = "";
            if (string.IsNullOrEmpty(tabText))
                finalTabText = "Script " + Data.TotalTabs + ".lua"; 
            else
                finalTabText = tabText;

            tabPage.Text = finalTabText;

            // Name //
            if (string.IsNullOrEmpty(name))
                tabPage.Name = "tabPage" + Data.TotalTabs;
            else
                tabPage.Name = name;

            // WebBrowser //
            IDETabs.Controls.Add(tabPage);
            IDETabs.SelectTab(tabPage);

            WebView2 webView = new WebView2();
            webView.Name = "MonacoTab" + Data.TotalTabs;
            webView.Dock = DockStyle.Fill;
            webView.Parent = tabPage;

            InitializeWebView(text);
        }
        private void OnTabRemoved(object sender, ControlEventArgs e)
        {
            if (!Directory.Exists(Data.TabsFolder)) return;

            string path = Path.Combine(Data.TabsFolder, e.Control.Text + ".msploit");
            if (File.Exists(path)) File.Delete(path);
        }

        // Context Menu //
        private void KillRoblox_Click(object sender, EventArgs e)
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName == "RobloxPlayerBeta" || process.ProcessName == "eurotrucks2")
                    process.Kill();
            }
        }

        private void InjectSecond_Click(object sender, EventArgs e)
        {
            topMost.Disable();
            Data.injectorMain.Inject();
            topMost.Enable();
        }

        private void AddTab_Click(object sender, EventArgs e)
        {
            AddNewTab("", "", "");
        }

        // Main Buttons //
        private void Inject_Click(object sender, EventArgs e)
        {
            topMost.Disable();
            Data.injectorMain.Inject();
            topMost.Enable();
        }

        private async void Execute_Click(object sender, EventArgs e)
        {
            topMost.Disable();

            string script = await GetText();
            var data = Data.injectorMain.Execute(script);
            if (!data.success) topMost.MessageBoxShow(data.message, "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            topMost.Enable();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            SetText("");
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Data.API == "Synapse Z" ? Path.Combine(Data.injectorMain.synapseZ.FolderPath, "scripts") : Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "lua files (*.lua)|*.lua|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        var MainText = reader.ReadToEnd();
                        AddNewTab(MainText, "", Path.GetFileNameWithoutExtension(filePath));
                    }
                }
            }
        }

        private async void SaveFile_Click(object sender, EventArgs e)
        {
            string script = await GetText();

            try
            {
                var saveFileDialog = new System.Windows.Forms.SaveFileDialog
                {
                    InitialDirectory = Data.API == "Synapse Z" ? Path.Combine(Data.injectorMain.synapseZ.FolderPath, "scripts") : Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    Filter = "Lua files (*.lua)|*.lua|Text files (*.txt)|*.txt",
                    RestoreDirectory = true,
                    ShowHelp = false,
                    CheckFileExists = true
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK) File.WriteAllText(saveFileDialog.FileName, script);
            }
            catch
            {
                topMost.MessageBoxShow("Failed to save file.", "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Options_Click(object sender, EventArgs e)
        {
            if (Data.SettingsUIForm == null) Data.SettingsUIForm = new Settings();
            Data.SettingsUIForm.Show();
        }

        private void GameItem_Click(object sender, EventArgs e)
        {
            if (Data.ScriptsBloxScriptsForm == null) Data.ScriptsBloxScriptsForm = new ScriptBloxScripts();
            Data.ScriptsBloxScriptsForm.Show();
        }

        private void HotScripts_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (script_array.ContainsKey(e.ClickedItem.Text))
            {
                Script scriptData = script_array[e.ClickedItem.Text];

                if (scriptData.DiscordInvite != "") Process.Start("https://discord.gg/" + scriptData.DiscordInvite);
                var execute = Data.injectorMain.Execute(scriptData.ScriptData);
                if (!execute.success)
                    topMost.MessageBoxShow(execute.message, "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Load //
        private void KRNL_MainForm_Load(object sender, EventArgs e)
        {
            IDETabs.ControlRemoved += new ControlEventHandler(OnTabRemoved);

            if (Directory.Exists(Data.TabsFolder))
            {
                DirectoryInfo d = new DirectoryInfo(Data.TabsFolder);
                FileInfo[] Files = d.GetFiles("*.msploit");

                if (Files.Length > 1) IDETabs.Controls.Clear();
                foreach (FileInfo file in Files)
                {
                    string path = Path.Combine(Data.TabsFolder, file.Name);

                    if (File.Exists(path))
                    {
                        string text = File.ReadAllText(path);

                        if (!string.IsNullOrEmpty(text))
                            AddNewTab(text, "", Path.GetFileNameWithoutExtension(file.Name));
                        else File.Delete(path);
                    }
                }
            }

            if (Data.TotalTabs == 0) AddNewTab("", "Tab 1", "");

            HotScripts.DropDownItems.Clear();

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
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = scriptdata.Name.ToString();
                item.BackColor = Color.FromArgb(33, 33, 33);
                item.ForeColor = Color.White;
                HotScripts.DropDownItems.Add(item);
            }
        }
    }
}
