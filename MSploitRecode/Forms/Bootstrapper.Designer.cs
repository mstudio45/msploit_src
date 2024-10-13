namespace MSploitRecode
{
    partial class Bootstrapper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bootstrapper));
            this.TopBar = new System.Windows.Forms.Panel();
            this.ExecutorStatus = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Label();
            this.Maximize = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.TopBarName = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Progress = new MSploitRecode.RJProgressBar();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopBar.Controls.Add(this.ExecutorStatus);
            this.TopBar.Controls.Add(this.Minimize);
            this.TopBar.Controls.Add(this.Maximize);
            this.TopBar.Controls.Add(this.Close);
            this.TopBar.Controls.Add(this.TopBarName);
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(444, 51);
            this.TopBar.TabIndex = 2;
            // 
            // ExecutorStatus
            // 
            this.ExecutorStatus.AutoSize = true;
            this.ExecutorStatus.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.ExecutorStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.ExecutorStatus.Location = new System.Drawing.Point(98, 14);
            this.ExecutorStatus.Name = "ExecutorStatus";
            this.ExecutorStatus.Size = new System.Drawing.Size(0, 22);
            this.ExecutorStatus.TabIndex = 5;
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.Minimize.ForeColor = System.Drawing.SystemColors.Control;
            this.Minimize.Location = new System.Drawing.Point(361, 14);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(24, 22);
            this.Minimize.TabIndex = 3;
            this.Minimize.Text = "🗕";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Maximize
            // 
            this.Maximize.AutoSize = true;
            this.Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximize.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.Maximize.ForeColor = System.Drawing.SystemColors.Control;
            this.Maximize.Location = new System.Drawing.Point(385, 14);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(24, 22);
            this.Maximize.TabIndex = 2;
            this.Maximize.Text = "🗖";
            this.Maximize.Visible = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.Close.ForeColor = System.Drawing.SystemColors.Control;
            this.Close.Location = new System.Drawing.Point(411, 14);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(20, 22);
            this.Close.TabIndex = 1;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // TopBarName
            // 
            this.TopBarName.AutoSize = true;
            this.TopBarName.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.TopBarName.ForeColor = System.Drawing.SystemColors.Control;
            this.TopBarName.Location = new System.Drawing.Point(12, 14);
            this.TopBarName.Name = "TopBarName";
            this.TopBarName.Size = new System.Drawing.Size(80, 22);
            this.TopBarName.TabIndex = 0;
            this.TopBarName.Text = "msploit";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, 57);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(444, 206);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.Status.ForeColor = System.Drawing.SystemColors.Control;
            this.Status.Location = new System.Drawing.Point(12, 266);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(420, 22);
            this.Status.TabIndex = 7;
            this.Status.Text = "Initializing...";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(-3, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Restart the application if you got stuck.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Progress
            // 
            this.Progress.ChannelColor = System.Drawing.Color.Gray;
            this.Progress.ChannelHeight = 10;
            this.Progress.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.Progress.ForeBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Progress.ForeColor = System.Drawing.SystemColors.Control;
            this.Progress.Location = new System.Drawing.Point(12, 291);
            this.Progress.Name = "Progress";
            this.Progress.ShowMaximun = true;
            this.Progress.ShowValue = MSploitRecode.TextPosition.Center;
            this.Progress.Size = new System.Drawing.Size(420, 44);
            this.Progress.SliderColor = System.Drawing.Color.PaleGreen;
            this.Progress.SliderHeight = 15;
            this.Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Progress.SymbolAfter = "";
            this.Progress.SymbolBefore = "";
            this.Progress.TabIndex = 8;
            // 
            // Bootstrapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(444, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bootstrapper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSPLOIT - Bootstrapper";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Bootstrapper_Load);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Label ExecutorStatus;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label Maximize;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label TopBarName;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Status;
        private RJProgressBar Progress;
        private System.Windows.Forms.Label label2;
    }
}

