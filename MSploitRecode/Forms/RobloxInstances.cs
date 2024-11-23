using MSploitRecode.Classes;
using SeliwareAPI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSploitRecode.Forms
{
    public partial class RobloxInstances : Form
    {
        private const int SW_SHOWNORMAL = 1;

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetForegroundWindow(IntPtr hwnd);

        private Fade fade;
        private TopMost topMost;
        private List<Process> processes;

        public RobloxInstances(List<Process> processes)
        {
            this.processes = processes;

            InitializeComponent();
            this.Load += new System.EventHandler(Program.OnFromLoaded);
            this.FormClosed += Program.OnFromClosed;

            new Drag(this, this.TopBar);
            fade = new Fade(this);
            topMost = new TopMost(this);
        }

        // Functions //
        private void RefreshList()
        {
            this.InstanceList.SelectedIndex = -1;
            this.InstanceList.Items.Clear();

            for (int i = 0; i < this.processes.Count; i++)
            {
                Process process = this.processes[i];
                this.InstanceList.Items.Add("Roblox - PID: " + process.Id.ToString());
            }
        }

        // Top Bar //
        private void Close_Click(object sender, EventArgs e)
        {
           // Application.Exit();
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

        // Buttons //
        private void UseInstance_Click(object sender, EventArgs e)
        {
            if (this.InstanceList.SelectedIndex == -1)
            {
                topMost.MessageBoxShow("Please select an instance.", "MSPLOIT");
                return;
            }

            int PID;
            if (!int.TryParse(this.InstanceList.Text.Replace("Roblox - PID: ", ""), out PID))
            {
                topMost.MessageBoxShow("Something has failed.", "MSPLOIT");
                return;
            }

            Process process = Process.GetProcessById(PID);
            if (process == null)
            {
                topMost.MessageBoxShow("Instance has been closed, list refreshed.", "MSPLOIT");
                RefreshList();
                return;
            }

            Data.SelectedPID = PID;
            this.Close();
        }

        private void ForceToTop_Click(object sender, EventArgs e)
        {
            if (this.InstanceList.SelectedIndex == -1)
            {
                topMost.MessageBoxShow("Please select an instance.", "MSPLOIT");
                return;
            }

            int PID;
            if (!int.TryParse(this.InstanceList.Text.Replace("Roblox - PID: ", ""), out PID))
            {
                topMost.MessageBoxShow("Something has failed.", "MSPLOIT");
                return;
            }

            Process process = Process.GetProcessById(PID);
            if (process == null)
            {
                topMost.MessageBoxShow("Instance has been closed, list refreshed.", "MSPLOIT");
                RefreshList();
                return;
            }

            ShowWindow(process.MainWindowHandle, SW_SHOWNORMAL);
            SetForegroundWindow(process.MainWindowHandle);
        }

        // Load //
        private void RobloxInstances_Load(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}