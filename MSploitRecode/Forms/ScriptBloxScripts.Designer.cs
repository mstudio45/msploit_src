namespace MSploitRecode.Forms
{
    partial class ScriptBloxScripts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptBloxScripts));
            this.TopBar = new System.Windows.Forms.Panel();
            this.ExecutorStatus = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Label();
            this.Maximize = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Label();
            this.TopBarName = new System.Windows.Forms.Label();
            this.ScriptsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MoreInfo = new System.Windows.Forms.Panel();
            this.CloseMoreInfo = new MSploit.RoundifiedButton();
            this.ExecuteMoreInfo = new MSploit.RoundifiedButton();
            this.MoreInfoText = new System.Windows.Forms.Label();
            this.MoreInfoImage = new System.Windows.Forms.PictureBox();
            this.SearchInput = new MSploitRecode.RJTextBox();
            this.LoadMore = new MSploit.RoundifiedButton();
            this.TopBar.SuspendLayout();
            this.MoreInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoreInfoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopBar.Controls.Add(this.ExecutorStatus);
            this.TopBar.Controls.Add(this.Minimize);
            this.TopBar.Controls.Add(this.Maximize);
            this.TopBar.Controls.Add(this.CloseBtn);
            this.TopBar.Controls.Add(this.TopBarName);
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(739, 51);
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
            this.Minimize.Location = new System.Drawing.Point(656, 14);
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
            this.Maximize.Location = new System.Drawing.Point(680, 14);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(24, 22);
            this.Maximize.TabIndex = 2;
            this.Maximize.Text = "🗖";
            this.Maximize.Visible = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseBtn.Location = new System.Drawing.Point(706, 14);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(20, 22);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "X";
            this.CloseBtn.Click += new System.EventHandler(this.Close_Click);
            // 
            // TopBarName
            // 
            this.TopBarName.AutoSize = true;
            this.TopBarName.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.TopBarName.ForeColor = System.Drawing.SystemColors.Control;
            this.TopBarName.Location = new System.Drawing.Point(12, 14);
            this.TopBarName.Name = "TopBarName";
            this.TopBarName.Size = new System.Drawing.Size(180, 22);
            this.TopBarName.TabIndex = 0;
            this.TopBarName.Text = "msploit - Scripts";
            // 
            // ScriptsPanel
            // 
            this.ScriptsPanel.AutoScroll = true;
            this.ScriptsPanel.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.ScriptsPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.ScriptsPanel.Location = new System.Drawing.Point(17, 57);
            this.ScriptsPanel.Name = "ScriptsPanel";
            this.ScriptsPanel.Size = new System.Drawing.Size(748, 326);
            this.ScriptsPanel.TabIndex = 8;
            // 
            // MoreInfo
            // 
            this.MoreInfo.BackColor = System.Drawing.Color.Transparent;
            this.MoreInfo.Controls.Add(this.CloseMoreInfo);
            this.MoreInfo.Controls.Add(this.ExecuteMoreInfo);
            this.MoreInfo.Controls.Add(this.MoreInfoText);
            this.MoreInfo.Controls.Add(this.MoreInfoImage);
            this.MoreInfo.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.MoreInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.MoreInfo.Location = new System.Drawing.Point(0, 57);
            this.MoreInfo.Name = "MoreInfo";
            this.MoreInfo.Size = new System.Drawing.Size(739, 387);
            this.MoreInfo.TabIndex = 11;
            this.MoreInfo.Visible = false;
            // 
            // CloseMoreInfo
            // 
            this.CloseMoreInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.CloseMoreInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.CloseMoreInfo.BorderColor = System.Drawing.Color.Gray;
            this.CloseMoreInfo.BorderRadius = 20;
            this.CloseMoreInfo.BorderSize = 0;
            this.CloseMoreInfo.FlatAppearance.BorderSize = 0;
            this.CloseMoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseMoreInfo.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.CloseMoreInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseMoreInfo.Location = new System.Drawing.Point(376, 335);
            this.CloseMoreInfo.Name = "CloseMoreInfo";
            this.CloseMoreInfo.Size = new System.Drawing.Size(197, 37);
            this.CloseMoreInfo.TabIndex = 13;
            this.CloseMoreInfo.Text = "Close";
            this.CloseMoreInfo.TextColor = System.Drawing.SystemColors.Control;
            this.CloseMoreInfo.UseVisualStyleBackColor = false;
            this.CloseMoreInfo.Click += new System.EventHandler(this.CloseMoreInfo_Click);
            // 
            // ExecuteMoreInfo
            // 
            this.ExecuteMoreInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ExecuteMoreInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ExecuteMoreInfo.BorderColor = System.Drawing.Color.Gray;
            this.ExecuteMoreInfo.BorderRadius = 20;
            this.ExecuteMoreInfo.BorderSize = 0;
            this.ExecuteMoreInfo.FlatAppearance.BorderSize = 0;
            this.ExecuteMoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteMoreInfo.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.ExecuteMoreInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.ExecuteMoreInfo.Location = new System.Drawing.Point(173, 335);
            this.ExecuteMoreInfo.Name = "ExecuteMoreInfo";
            this.ExecuteMoreInfo.Size = new System.Drawing.Size(197, 37);
            this.ExecuteMoreInfo.TabIndex = 12;
            this.ExecuteMoreInfo.Text = "Execute";
            this.ExecuteMoreInfo.TextColor = System.Drawing.SystemColors.Control;
            this.ExecuteMoreInfo.UseVisualStyleBackColor = false;
            this.ExecuteMoreInfo.Click += new System.EventHandler(this.ExecuteMoreInfo_Click);
            // 
            // MoreInfoText
            // 
            this.MoreInfoText.Font = new System.Drawing.Font("Consolas", 11F);
            this.MoreInfoText.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.MoreInfoText.Location = new System.Drawing.Point(3, 248);
            this.MoreInfoText.Name = "MoreInfoText";
            this.MoreInfoText.Size = new System.Drawing.Size(733, 78);
            this.MoreInfoText.TabIndex = 1;
            this.MoreInfoText.Text = "✅ Script Name\r\nBy: Developer";
            this.MoreInfoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoreInfoImage
            // 
            this.MoreInfoImage.Location = new System.Drawing.Point(0, 3);
            this.MoreInfoImage.Name = "MoreInfoImage";
            this.MoreInfoImage.Size = new System.Drawing.Size(736, 242);
            this.MoreInfoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoreInfoImage.TabIndex = 0;
            this.MoreInfoImage.TabStop = false;
            // 
            // SearchInput
            // 
            this.SearchInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.SearchInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.SearchInput.BorderFocusColor = System.Drawing.Color.Gray;
            this.SearchInput.BorderRadius = 10;
            this.SearchInput.BorderSize = 1;
            this.SearchInput.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.SearchInput.ForeColor = System.Drawing.SystemColors.Control;
            this.SearchInput.Location = new System.Drawing.Point(17, 392);
            this.SearchInput.Margin = new System.Windows.Forms.Padding(4);
            this.SearchInput.Multiline = false;
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.SearchInput.PasswordChar = false;
            this.SearchInput.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.SearchInput.PlaceholderText = "Search...";
            this.SearchInput.Size = new System.Drawing.Size(404, 37);
            this.SearchInput.TabIndex = 10;
            this.SearchInput.Texts = "";
            this.SearchInput.UnderlinedStyle = false;
            // 
            // LoadMore
            // 
            this.LoadMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.LoadMore.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.LoadMore.BorderColor = System.Drawing.Color.Gray;
            this.LoadMore.BorderRadius = 20;
            this.LoadMore.BorderSize = 0;
            this.LoadMore.FlatAppearance.BorderSize = 0;
            this.LoadMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadMore.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.LoadMore.ForeColor = System.Drawing.SystemColors.Control;
            this.LoadMore.Location = new System.Drawing.Point(428, 392);
            this.LoadMore.Name = "LoadMore";
            this.LoadMore.Size = new System.Drawing.Size(299, 37);
            this.LoadMore.TabIndex = 9;
            this.LoadMore.Text = "Search Scripts";
            this.LoadMore.TextColor = System.Drawing.SystemColors.Control;
            this.LoadMore.UseVisualStyleBackColor = false;
            this.LoadMore.Click += new System.EventHandler(this.LoadMore_Click);
            // 
            // ScriptBloxScripts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(739, 446);
            this.Controls.Add(this.MoreInfo);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.LoadMore);
            this.Controls.Add(this.ScriptsPanel);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScriptBloxScripts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSPLOIT - ScriptBloxScripts";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ScriptBloxScripts_Load);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.MoreInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoreInfoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Label ExecutorStatus;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label Maximize;
        private System.Windows.Forms.Label CloseBtn;
        private System.Windows.Forms.Label TopBarName;
        private System.Windows.Forms.FlowLayoutPanel ScriptsPanel;
        private MSploit.RoundifiedButton LoadMore;
        private RJTextBox SearchInput;
        private System.Windows.Forms.Panel MoreInfo;
        private System.Windows.Forms.Label MoreInfoText;
        private System.Windows.Forms.PictureBox MoreInfoImage;
        private MSploit.RoundifiedButton CloseMoreInfo;
        private MSploit.RoundifiedButton ExecuteMoreInfo;
    }
}