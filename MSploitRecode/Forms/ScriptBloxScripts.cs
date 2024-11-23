using MSploitRecode.Classes;
using MSploitRecode.Forms.synapse_ui;
using Newtonsoft.Json;
using SeliwareAPI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace MSploitRecode.Forms
{
    public partial class ScriptBloxScripts : Form
    {
        private const int SB_HORZ = 0; // Horizontal scrollbar
        private const int SB_VERT = 1; // Vertical scrollbar

        [DllImport("user32.dll")]
        public static extern int ShowScrollBar(IntPtr hWnd, int wBar, int bShow);

        private Fade fade;
        private TopMost topMost;

        private WebClient webClient = new WebClient { Proxy = null };

        public ScriptBloxScripts()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(Program.OnFromLoaded);
            this.FormClosed += Program.OnFromClosed;

            new Drag(this, this.TopBar);
            fade = new Fade(this);
            topMost = new TopMost(this);

            this.Minimize.Location = this.Maximize.Location;
            this.MoreInfo.Visible = false;
        }

        // Functions //
        private readonly int Width = 215;
        private readonly int Height = 200;
        private Dictionary<string, MemoryStream> imageStreams = new Dictionary<string, MemoryStream>();
        private string currentScript = "";

        public static string AbbreviateNumber(long number)
        {
            if (number < 1000) return number.ToString();

            string[] suffixes = { "", "K", "M", "B", "T" };
            int suffixIndex = 0;
            double value = number;

            while (value >= 1000 && suffixIndex < suffixes.Length - 1)
            {
                value /= 1000;
                suffixIndex++;
            }

            return $"{value:N1}{suffixes[suffixIndex]}";
        }

        private Panel CreateScriptCard(string name, string uploader, string script, long views, string imageUrl, bool? verified)
        {
            Panel card = new Panel();
            card.Margin = new Padding(10);
            card.Size = new Size(Width, Height);

            // Image //
            PictureBox scriptImage = new PictureBox();
            scriptImage.Size = new Size(Width, Height - 35);
            scriptImage.Location = new Point(0, 0);
            scriptImage.BackColor = Color.Transparent;
            scriptImage.BorderStyle = BorderStyle.FixedSingle;
            scriptImage.SizeMode = PictureBoxSizeMode.StretchImage;

            // Name //
            Label scriptName = new Label();
            scriptName.BackColor = Color.FromArgb(28, 28, 28);
            scriptName.AutoSize = false;
            scriptName.Location = new Point(0, Height - 35);
            scriptName.Size = new Size(Width, 35);

            scriptName.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            scriptName.Text = (verified == true ? "✅ " : "") + name;
            scriptName.TextAlign = ContentAlignment.MiddleCenter;

            scriptImage.Image = MSploitRecode.Properties.Resources.no_script;

            // Views //
            Label scriptViews = new Label();
            scriptViews.Margin = new Padding(10);

            scriptViews.ForeColor = Color.Black;
            scriptViews.AutoSize = true;
            scriptViews.Location = new Point(10, 10);

            scriptViews.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            scriptViews.Text = "👁 " + AbbreviateNumber(views);
            scriptViews.TextAlign = ContentAlignment.MiddleCenter;
            new RoundLabel(scriptViews, 20, Color.White);

            // Add //
            card.Controls.Add(scriptImage);
            card.Controls.Add(scriptName);
            card.Controls.Add(scriptViews);

            // Code //
            scriptViews.BringToFront();
            Task.Run(() => {
                // Load Image //
                try
                {
                    if (imageStreams.ContainsKey(imageUrl) && imageStreams[imageUrl] != null)
                    {
                        scriptImage.Image = Bitmap.FromStream(imageStreams[imageUrl]);
                        return;
                    }

                    using (WebClient wc = new WebClient())
                    {
                        byte[] data = wc.DownloadData(new Uri(imageUrl));
                        using (var stream = new System.IO.MemoryStream(data))
                        {
                            imageStreams[imageUrl] = stream;
                            scriptImage.Image = Bitmap.FromStream(stream);
                        }
                    }
                } 
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
               
            });

            scriptImage.Click += (s, e) =>
            {
                this.MoreInfoImage.Image = scriptImage.Image;
                this.MoreInfoText.Text = $"{(verified == true ? "✅ " : "") + name}\nUploaded By: {uploader}";
                currentScript = script;
                this.MoreInfo.Visible = true;
            };

            return card;
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

        // Buttons //
        private void ExecuteMoreInfo_Click(object sender, EventArgs e)
        {
            if (currentScript == "") return;
            topMost.Disable();

            var data = Data.injectorMain.Execute(currentScript);
            if (!data.success)
                topMost.MessageBoxShow(data.message, "MSPLOIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            topMost.Enable();
        }

        private void CloseMoreInfo_Click(object sender, EventArgs e)
        {
            currentScript = "";
            this.MoreInfo.Visible = false;
        }

        // Load //
        private void ScriptBloxScripts_Load(object sender, EventArgs e)
        {
        }

        // Load Scripts //
        private async void LoadMore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.SearchInput.Texts)) return;
            if (this.LoadMore.Text == "Loading...") return;

            this.LoadMore.Text = "Loading...";
            await Task.Delay(250);

            try
            {
                this.ScriptsPanel.Controls.Clear();

                string data = webClient.DownloadString("https://scriptblox.com/api/script/fetch?filters=newest&q=" + HttpUtility.UrlEncode(this.SearchInput.Texts));
                dynamic jsonData = JsonConvert.DeserializeObject(data);

                foreach (var item in jsonData["result"]["scripts"])
                {
                    try
                    {
                        if (item["isPatched"] == false)
                        {
                            string img = item["game"]["imageUrl"].ToString();
                            if (!img.StartsWith("http")) img = "https://scriptblox.com" + img;

                            this.ScriptsPanel.Controls.Add(
                                CreateScriptCard(
                                    item["title"].ToString(),
                                    item["owner"]["username"].ToString(),

                                    $"loadstring(game:HttpGet('https://rawscripts.net/raw/{item["slug"]}'))()",

                                    (long)item["views"],

                                    img,

                                    item["verified"] == true
                                )
                            );
                        }
                    }
                    catch { }
                    await Task.Delay(10);
                }
            }
            catch (Exception ex)
            {
                topMost.MessageBoxShow("Failed to load scripts:\n" + ex.Message, "MSPLOIT");
            }

            await Task.Delay(500);
            this.LoadMore.Text = "Search Scripts";
        }
    }
}