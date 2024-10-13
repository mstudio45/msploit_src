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

namespace MSploitRecode.Forms.krnl_ui
{
    public partial class KRNL_MainForm : Form
    {
        private Fade fade;

        public KRNL_MainForm()
        {
            InitializeComponent();

            new Drag(this, this.TopBar);
            fade = new Fade(this);
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

            Environment.Exit(0);
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
                MessageBox.Show($"Error initializing WebView2: {ex.Message}", "MSPLOIT");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "MSPLOIT");
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
            InjectorMain.Inject();
        }

        private void AddTab_Click(object sender, EventArgs e)
        {
            AddNewTab("", "", "");
        }

        // Main Buttons //
        private void Inject_Click(object sender, EventArgs e)
        {
            InjectorMain.Inject();
        }

        private async void Execute_Click(object sender, EventArgs e)
        {
            string script = await GetText();
            var data = InjectorMain.Execute(script);
            if (!data.success) MessageBox.Show(data.message, "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            SetText("");
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Data.API == "Synapse Z" ? Path.Combine(InjectorMain.synapseZ.FolderPath, "scripts") : Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
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
                    InitialDirectory = Data.API == "Synapse Z" ? Path.Combine(InjectorMain.synapseZ.FolderPath, "scripts") : Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    Filter = "Lua files (*.lua)|*.lua|Text files (*.txt)|*.txt",
                    RestoreDirectory = true,
                    ShowHelp = false,
                    CheckFileExists = true
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK) File.WriteAllText(saveFileDialog.FileName, script);
            }
            catch
            {
                MessageBox.Show("Failed to save file.", "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }
    }
}
