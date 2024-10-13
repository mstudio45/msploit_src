using MSploitRecode.Classes;
using SeliwareAPI;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSploitRecode.Forms
{
    public partial class UISelect : Form
    {
        private Fade fade;

        public UISelect()
        {
            InitializeComponent();

            new Drag(this, this.TopBar);
            fade = new Fade(this);
        }

        // Top Bar //
        private void Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
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
            
            File.WriteAllText(Data.UIFile, this.UIList.Text);
            File.WriteAllText(Data.APIFile, this.APIList.Text);
        }

        private Tuple<string, string> Get()
        {
            string UI = File.Exists(Data.UIFile) ? File.ReadAllText(Data.UIFile) : "";
            string API = File.Exists(Data.APIFile) ? File.ReadAllText(Data.APIFile) : "";

            return Tuple.Create<string, string>(UI, API);
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
                await fade.FadeOut();
                form.Show();
                callback?.Invoke();
            }
        }

        // API Functions //
        private string GetBackupAPI(string API)
        {
            return API.Equals("Synapse Z", StringComparison.OrdinalIgnoreCase) ? "Seliware" : "Synapse Z";
        }
        private bool TryLoadAPI(string API)
        {
            if (API.Equals("Seliware", StringComparison.OrdinalIgnoreCase) && Data.SeliwareLoaded == false)
            {
                this.TopMost = false;
                Data.SeliwareLoaded = true;

                if (!File.Exists("C:\\Windows\\System32\\drivers\\etc\\hosts")) File.Create("C:\\Windows\\System32\\drivers\\etc\\hosts");
                Data.Seliware = Seliware.Initialize();
                this.TopMost = true;
            }

            if (API.Equals("Synapse Z", StringComparison.OrdinalIgnoreCase) && Data.SynapseZ)
            {
                Data.API = API;
                return true;
            }
            else if (API.Equals("Seliware", StringComparison.OrdinalIgnoreCase) && Data.Seliware)
            {
                Data.API = API;
                return true;
            }

            return false;
        }

        public bool LoadAPI(string API)
        {
            if (API == "") return false;
            if (TryLoadAPI(API)) return true;

            string backupAPI = GetBackupAPI(API);
            if (TryLoadAPI(backupAPI))
            {
                this.TopMost = false;
                MessageBox.Show($"{API} API failed to load, using {backupAPI} as a backup API.", "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.TopMost = true;
                Data.API = backupAPI;
                return true;
            }

            this.TopMost = false;
            MessageBox.Show("Every API is patched.", "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.TopMost = true;
            return false;
        }

        // Load //
        private async void UISelect_Load(object sender, EventArgs e)
        {
            await fade.FadeIn();
            Tuple<string, string> DATA = Get();

            if (!LoadAPI(DATA.Item2)) return;
            await LoadUI(DATA.Item1, () =>
            {
                this.Close();
            });
        }

        private async void Load_Click(object sender, EventArgs e)
        {
            if (this.UIList.SelectedIndex == -1)
            {
                this.TopMost = false;
                MessageBox.Show("Please select an UI.", "MSPLOIT");
                this.TopMost = true;
                return;
            }

            if (this.APIList.SelectedIndex == -1)
            {
                this.TopMost = false;
                MessageBox.Show("Please select an API.", "MSPLOIT");
                this.TopMost = true;
                return;
            }

            if (!LoadAPI(this.APIList.Text)) return;
            await LoadUI(this.UIList.Text, () =>
            {
                Save();
                this.Close();
            });
        }
    }
}
