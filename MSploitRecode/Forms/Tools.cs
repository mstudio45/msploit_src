using MSploitRecode.Classes;
using SeliwareAPI;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSploitRecode.Forms
{
    public partial class Tools : Form
    {
        private Fade fade;
        private TopMost topMost;

        public Tools()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(Program.OnFromLoaded);
            this.FormClosed += Program.OnFromClosed;

            new Drag(this, this.TopBar);
            fade = new Fade(this);
            topMost = new TopMost(this);

            this.Minimize.Location = this.CloseBtn.Location;
            this.Maximize.Visible = false;
            this.CloseBtn.Visible = false; 
        }

        // Top Bar //
        private void Close_Click(object sender, EventArgs e)
        {
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

        // Open Folder //
        private void OpenFolder_Click(object sender, EventArgs e)
        {
            switch (this.FolderList.Text)
            {
                case "workspace":
                    if (Data.API == "Synapse Z")
                        Process.Start("explorer.exe", Path.Combine(Data.injectorMain.synapseZ.FolderPath, "workspace"));
                    else if (Data.API == "Seliware")
                        Process.Start("explorer.exe", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "seliware-workspace"));
                    break;

                case "autoexec":
                    if (Data.API == "Synapse Z")
                        Process.Start("explorer.exe", Path.Combine(Data.injectorMain.synapseZ.FolderPath, "autoexec"));
                    else if (Data.API == "Seliware")
                        Process.Start("explorer.exe", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "seliware-autoexec"));
                    break;

                case "Synapse Z":
                    Process.Start($"explorer.exe", Data.injectorMain.synapseZ.FolderPath);
                    break;

                case "Seliware":
                    Process.Start($"explorer.exe", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Seliware"));
                    break;

                default:
                    break;
            }
        }

        // Synapse Z //
        private void Info_SynapseZ_Click(object sender, EventArgs e)
        {
            switch (Data.injectorMain.synapseZ.Info())
            {
                case 0:
                    break;

                default:
                    topMost.MessageBoxShow(Data.injectorMain.synapseZ.GetLatestErrorMessage(), "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void Redeem_SynapseZ_Click(object sender, EventArgs e)
        {
            switch (Data.injectorMain.synapseZ.Redeem())
            {
                case 0:
                    break;

                default:
                    topMost.MessageBoxShow(Data.injectorMain.synapseZ.GetLatestErrorMessage(), "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void ResetHWID_SynapseZ_Click(object sender, EventArgs e)
        {
            switch (Data.injectorMain.synapseZ.ResetHwid())
            {
                case 0:
                    break;

                default:
                    topMost.MessageBoxShow(Data.injectorMain.synapseZ.GetLatestErrorMessage(), "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
    }
}