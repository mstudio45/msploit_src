using MSploitRecode.Classes;
using SeliwareAPI;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSploitRecode.Forms
{
    public partial class Settings : Form
    {
        private Fade fade;
        private TopMost topMost;
        private bool clicked;

        public Settings()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(Program.OnFromLoaded);
            this.FormClosed += Program.OnFromClosed;

            new Drag(this, this.TopBar);
            fade = new Fade(this);
            topMost = new TopMost(this);
            this.Opacity = 1;

            this.Minimize.Location = this.Maximize.Location;
            this.Maximize.Visible = false;
        }

        // Top Bar //
        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        // Load //
        private void Settings_Load(object sender, EventArgs e)
        {
            this.OnTop.Checked = (bool)Data.Settings.TopMost;
            this.AutoAttach.Checked = (bool)Data.Settings.AutoAttach;
        }

        private async void DeloadUI_Click(object sender, EventArgs e)
        {
            if (clicked) return;
            clicked = true;

            try
            {
                if (Data.injectorMain.GetData().IsInjected)
                {
                    clicked = false;
                    topMost.MessageBoxShow("You are injected, close Roblox to switch API/UI.", "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Data.ToolsUIForm.Close();
                Data.ToolsUIForm = null;

                Data.CurrentUIForm.Close();
                Data.CurrentUIForm = null;

                await fade.FadeOut();
                new UISelect(false).Show();
                this.Close();
            }
            catch (Exception ex)
            {
                clicked = false;
                topMost.MessageBoxShow(ex.Message, "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Classes.Settings.SaveSettings(new SettingsData
            {
                TopMost = this.OnTop.Checked,
                MultiInstance = this.MultiInstance.Checked,
                AutoAttach = this.AutoAttach.Checked
            });

            var SettingsData = Classes.Settings.GetSettings();
            if (SettingsData.success == true)
            {
                Data.SettingsLoaded = true;
                Data.Settings = SettingsData.data;
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ToolsUI_Click(object sender, EventArgs e)
        {
            if (Data.ToolsUIForm == null) Data.ToolsUIForm = new Tools();
            Data.ToolsUIForm.Show();
        }

        private void OpenScriptsUI_Click(object sender, EventArgs e)
        {
            if (Data.ScriptsBloxScriptsForm == null) Data.ScriptsBloxScriptsForm = new ScriptBloxScripts();
            Data.ScriptsBloxScriptsForm.Show();
        }
    }
}
