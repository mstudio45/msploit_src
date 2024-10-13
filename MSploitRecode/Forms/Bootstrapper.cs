using MSploitRecode.APIs;
using MSploitRecode.Classes;
using MSploitRecode.Forms;
using SeliwareAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSploitRecode
{
    public partial class Bootstrapper : Form
    {
        private Fade fade;
        private Random random = new Random();
        private WebClient webClient = new WebClient { Proxy = null };
        private WebClient webClientNoProgress = new WebClient { Proxy = null };


        public Bootstrapper()
        {
            InitializeComponent();

            this.Minimize.Location = this.Maximize.Location;
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

        // Functions //
        private static bool IsLikelyRunFromZipFolder()
        {
            var path = System.Reflection.Assembly.GetEntryAssembly().Location;
            var fileInfo = new FileInfo(path);
            return fileInfo.Attributes.HasFlag(FileAttributes.ReadOnly);
        }

        private static bool IsRunFromTempFolder()
        {
            var path = System.Reflection.Assembly.GetEntryAssembly().Location;
            var temp = Path.GetTempPath();
            return path.IndexOf(temp, StringComparison.OrdinalIgnoreCase) == 0;
        }

        private async Task<bool> DownloadAndExtract(string NAME, string URL, bool FETCH, string ZIP, string FOLDER)
        {
            if (FETCH)
            {
                Tuple<bool, string> downloadURL = GetString(URL, true);
                if (!downloadURL.Item1)
                {
                    MessageBox.Show("Failed to fetch download URL for " + NAME + "!", "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                URL = downloadURL.Item2;
            }

            Status.Text = "Downloading " + NAME + "...";

            if (Directory.Exists(FOLDER)) Directory.Delete(FOLDER, true);
            if (File.Exists(ZIP)) File.Delete(ZIP);

            this.Progress.Value = 0;
            await webClient.DownloadFileTaskAsync(
                new Uri(URL),
                ZIP
            );

            while (webClient.IsBusy) await Task.Delay(1000); // Wait until it's not busy

            if (!File.Exists(ZIP))
            {
                MessageBox.Show("Failed to download " + NAME + "!", "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            this.Progress.Value = 0;
            Status.Text = "Extracting " + NAME + "...";

            ZipFile.ExtractToDirectory(ZIP, FOLDER);
            this.Progress.Value = 50;

            await Task.Delay(1000);
            File.Delete(ZIP);
            this.Progress.Value = 100;

            Status.Text = NAME + " downloaded.";
            await Task.Delay(500);
            return true;
        }

        private Tuple<bool, string> GetString(string URL, bool removeNewLine)
        {
            string data = "";
            bool success = true;

            try
            {
                data = webClientNoProgress.DownloadString(URL);
                data = removeNewLine == true ? data.Replace("\n", "").Replace("\r", "") : data;
            }
            catch { success = false; }

            return Tuple.Create<bool, string>(success, data);
        }

        // Load //
        private async void Bootstrapper_Load(object sender, EventArgs e)
        {
            if (IsRunFromTempFolder() || IsLikelyRunFromZipFolder())
            {
                MessageBox.Show("It seems you started MSPLOIT in a temporary folder/inside a zip file. Please extract it into a folder!", "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
                return;
            }

            webClient.DownloadProgressChanged += (progressSender, progressE) => { this.Progress.Value = progressE.ProgressPercentage; };
            await fade.FadeIn();

            bool ReDownload = File.Exists(Directory.GetCurrentDirectory() + @"\clear_files");

            // Get Data //
            this.Status.Text = "Fetching data...";
            this.Progress.Value = 0;
            await Task.Delay(500);

            Data.Changelogs = GetString(Data.DOMAIN + "files/changelogs", false).Item2;
            Tuple<bool, string> GuiVersion = GetString(Data.DOMAIN + "files/gui_ver", true);

            // Check Version //
            if (GuiVersion.Item1 == false)
            {
                MessageBox.Show("Failed to check MSPLOIT version.", "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                await Task.Delay(250);
                if (Data.CURRENT_GUI_VERSION != GuiVersion.Item2)
                {
                    this.TopMost = false;

                    DialogResult dr = MessageBox.Show("You are using an outdated version. Do you want to update?\n\nChangelogs:\n" + Data.Changelogs, "MSPLOIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        File.Create(Directory.GetCurrentDirectory() + @"\clear_files");
                        Process.Start(Data.DOMAIN);
                        Environment.Exit(0);
                        return;
                    }
                    else Data.OUTDATED = true;

                    this.TopMost = true;
                }

                Data.GUI_VERSION = GuiVersion.Item2;
            }

            // Create Directories //
            this.Status.Text = "Checking files...";
            this.Progress.Value = 25;
            await Task.Delay(500);

            if (ReDownload)
            {
                if (Directory.Exists(Data.TempFolder)) Directory.Delete(Data.TempFolder, true);
                if (Directory.Exists(Data.BinFolder)) Directory.Delete(Data.BinFolder, true);
            }
            if (!Directory.Exists(Data.BinFolder)) Directory.CreateDirectory(Data.BinFolder);
            if (!Directory.Exists(Data.ExecutorsFolder)) Directory.CreateDirectory(Data.ExecutorsFolder);

            // Download //
            bool IDEMissing = false;
            if (!Directory.Exists(Data.IDEFolder))
                IDEMissing = true;
            else
            {
                if (!File.Exists(Path.Combine(Data.IDEFolder, @"KRNL\Monaco.html")))
                    IDEMissing = true;
                else if (!File.Exists(Path.Combine(Data.IDEFolder, @"SynapseX\Editor.html")))
                    IDEMissing = true;
                else if (!File.Exists(Path.Combine(Data.IDEFolder, @"msploit\Monaco.html")))
                    IDEMissing = true;
            }

            // Create Temp //
            if (IDEMissing) { if (!Directory.Exists(Data.TempFolder)) Directory.CreateDirectory(Data.TempFolder); }

            // Download //
            if (IDEMissing)
            {
                bool IDESuccess = await DownloadAndExtract("IDE", "https://msploit.mstudio45.com/files/ide", true, Path.Combine(Data.TempFolder, "IDE.zip"), Data.BinFolder);
                if (!IDESuccess)
                {
                    Environment.Exit(0);
                    return;
                }
            }

            this.Progress.Value = 50;

            // Seliware API //
            // loaded in uiselect

            // Synapse Z API //
            this.Status.Text = "Initializing Synapse Z...";
            await Task.Delay(250);
            if (InjectorMain.synapseZ.FindLauncher() == String.Empty)
            {
                bool SynZSuccess = await DownloadAndExtract("Synapse Z", "https://synapse-z.netlify.app/Synapse%20Z.zip", false, Path.Combine(Data.TempFolder, "SynapseZ.zip"), InjectorMain.synapseZ.FolderPath);

                Data.SynapseZ = SynZSuccess && InjectorMain.synapseZ.FindLauncher() != String.Empty;
                if (Data.SynapseZ)
                {
                    this.TopMost = false;
                    MessageBox.Show("If you have used Synapse Z before, copy the bin and workspace folder into '" + InjectorMain.synapseZ.FolderPath + "'.", "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.TopMost = true;
                }
            }
            else Data.SynapseZ = true;

            // Check APIs //
            if (!Data.Seliware && !Data.SynapseZ)
            {
                this.TopMost = false;
                MessageBox.Show("Failed to initialize Seliware and Synapse Z API.", "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
                return;
            }

            if (Data.OUTDATED)
                this.Status.Text = "Loading v" + Data.CURRENT_GUI_VERSION + " (v" + Data.GUI_VERSION + ")...";
            else
                this.Status.Text = "Loading v" + Data.CURRENT_GUI_VERSION + "...";
            this.Progress.Value = 100;

            // Load UI Pick //
            await Task.Delay(500);
            await fade.FadeOut();
            new UISelect().Show();
            this.Close();
        }
    }
}
