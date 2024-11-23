using MSploitRecode.Classes;
using SeliwareAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSploitRecode.Forms
{
    public partial class UISelect : Form
    {
        private Fade fade;
        private TopMost topMost;
        private bool clicked;
        private bool loadFromFile;

        public UISelect(bool loadFromFile)
        {
            this.loadFromFile = loadFromFile;

            InitializeComponent();
            this.Load += new System.EventHandler(Program.OnFromLoaded);
            this.FormClosed += Program.OnFromClosed;

            new Drag(this, this.TopBar);
            fade = new Fade(this);
            topMost = new TopMost(this);

            this.Minimize.Location = this.Maximize.Location;
            this.Maximize.Visible = false;
        }

        // Top Bar //
        private void Close_Click(object sender, EventArgs e)
        {
            Program.bootstrapper.Close();
            Application.Exit();
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Data Functions //
        private void Save()
        {
            if (!this.SaveUI.Checked) return;

            Classes.Settings.SaveSettings(new SettingsData
            {
                API = this.APIList.Text,
                UI = this.UIList.Text,
                ToolsUIEnabled = this.OpenTools.Checked
            });
        }
        
        // UI Functions //
        public async Task LoadUI(string UI, Action callback = null)
        {
            Form form = null;
            if (UI == "KRNL")
                form = new krnl_ui.KRNL_MainForm();
            else if (UI == "Synapse X")
                form = new synapse_ui.Synapse_MainForm();

            if (form != null)
            {
                Data.CurrentUIForm = form;
                await fade.FadeOut();
                form.Show();
                callback?.Invoke();
            }
        }

        // API Functions //
        private readonly Dictionary<string, Func<bool>> apiAvailability = new Dictionary<string, Func<bool>>(StringComparer.OrdinalIgnoreCase)
        {
            { "Synapse Z", () => Data.SynapseZ },
            { "Seliware", () => Data.Seliware }
        };
        
        private string GetBackupAPI(string API)
        {
            return API.Equals("Synapse Z", StringComparison.OrdinalIgnoreCase) ? "Seliware" : "Synapse Z";
        }

        private bool TryLoadAPI(string API)
        {
            switch (API)
            {
                case "Seliware":
                    if (Data.SeliwareLoaded == false)
                    {
                        this.TopMost = false;
                        Data.SeliwareLoaded = true;
                        if (!File.Exists("C:\\Windows\\System32\\drivers\\etc\\hosts")) File.Create("C:\\Windows\\System32\\drivers\\etc\\hosts");
                        Data.Seliware = Seliware.Initialize();

                        this.TopMost = true;
                    }

                    if (!apiAvailability["Seliware"]())
                        return false;

                    break;

                default:
                    if (!apiAvailability.ContainsKey(API))
                        return false;
                    if (!apiAvailability[API]())
                        return false;
                    break;
            }

            Data.API = API;
            return true;
        }

        public bool LoadAPI(string API)
        {
            // Check if API is valid //
            if (!string.IsNullOrEmpty(API) && TryLoadAPI(API)) 
                return true;

            // Try to use backup //
            string backupAPI = GetBackupAPI(API);
            if (TryLoadAPI(backupAPI))
            {
                topMost.MessageBoxShow($"{API} API failed to load, using {backupAPI} as a backup API.", "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Data.API = backupAPI;
                return true;
            }

            topMost.MessageBoxShow("Every API is patched/failed to load.", "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        // Load //
        private async void UISelect_Load(object sender, EventArgs e)
        {
            await fade.FadeIn();
            if (!Data.SettingsLoaded) return;

            // Load Saved Data //
            this.OpenTools.Checked = (bool)Data.Settings.ToolsUIEnabled;
            this.UIList.SelectedIndex = this.UIList.FindString(Data.Settings.UI);
            this.APIList.SelectedIndex = this.APIList.FindString(Data.Settings.API);

            if (this.loadFromFile)
            {
                if (LoadAPI(Data.Settings.API))
                    await LoadUI(Data.Settings.UI, () =>
                    {
                        if ((bool)Data.Settings.ToolsUIEnabled)
                        {
                            if (Data.ToolsUIForm == null) Data.ToolsUIForm = new Tools();
                            Data.ToolsUIForm.Show();
                        }

                        Data.injectorMain.Setup();
                        this.Close();
                    });
            }
        }

        private async void Load_Click(object sender, EventArgs e)
        {
            if (clicked) return;
            clicked = true;

            if (this.UIList.SelectedIndex == -1)
            {
                topMost.MessageBoxShow("Please select an UI.", "MSPLOIT");
                clicked = false;
                return;
            }

            if (this.APIList.SelectedIndex == -1)
            {
                topMost.MessageBoxShow("Please select an API.", "MSPLOIT");
                clicked = false;
                return;
            }

            // Load //
            if (!LoadAPI(this.APIList.Text))
            {
                clicked = false; 
                return;
            }

            await LoadUI(this.UIList.Text, () =>
            {
                Save();

                if (this.OpenTools.Checked)
                {
                    if (Data.ToolsUIForm == null) Data.ToolsUIForm = new Tools();
                    Data.ToolsUIForm.Show();
                }

                Data.injectorMain.Setup();
                this.Close();
            });
        }
    }
}
