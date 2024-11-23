namespace MSploitRecode.Forms
{
    partial class Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tools));
            this.TopBar = new System.Windows.Forms.Panel();
            this.ExecutorStatus = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Label();
            this.Maximize = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Label();
            this.TopBarName = new System.Windows.Forms.Label();
            this.FolderList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetHWID_SynapseZ = new MSploit.RoundifiedButton();
            this.Info_SynapseZ = new MSploit.RoundifiedButton();
            this.Redeem_SynapseZ = new MSploit.RoundifiedButton();
            this.OpenFolder = new MSploit.RoundifiedButton();
            this.TopBar.SuspendLayout();
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
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseBtn.Location = new System.Drawing.Point(411, 14);
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
            this.TopBarName.Size = new System.Drawing.Size(160, 22);
            this.TopBarName.TabIndex = 0;
            this.TopBarName.Text = "msploit - Tools";
            // 
            // FolderList
            // 
            this.FolderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.FolderList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FolderList.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.FolderList.ForeColor = System.Drawing.SystemColors.Control;
            this.FolderList.FormattingEnabled = true;
            this.FolderList.Items.AddRange(new object[] {
            "workspace",
            "autoexec",
            "Synapse Z",
            "Seliware"});
            this.FolderList.Location = new System.Drawing.Point(20, 80);
            this.FolderList.Name = "FolderList";
            this.FolderList.Size = new System.Drawing.Size(406, 30);
            this.FolderList.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(165, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Synapse Z:";
            // 
            // ResetHWID_SynapseZ
            // 
            this.ResetHWID_SynapseZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ResetHWID_SynapseZ.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ResetHWID_SynapseZ.BorderColor = System.Drawing.Color.Gray;
            this.ResetHWID_SynapseZ.BorderRadius = 20;
            this.ResetHWID_SynapseZ.BorderSize = 0;
            this.ResetHWID_SynapseZ.FlatAppearance.BorderSize = 0;
            this.ResetHWID_SynapseZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetHWID_SynapseZ.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.ResetHWID_SynapseZ.ForeColor = System.Drawing.SystemColors.Control;
            this.ResetHWID_SynapseZ.Location = new System.Drawing.Point(20, 251);
            this.ResetHWID_SynapseZ.Name = "ResetHWID_SynapseZ";
            this.ResetHWID_SynapseZ.Size = new System.Drawing.Size(406, 40);
            this.ResetHWID_SynapseZ.TabIndex = 8;
            this.ResetHWID_SynapseZ.Text = "Reset HWID";
            this.ResetHWID_SynapseZ.TextColor = System.Drawing.SystemColors.Control;
            this.ResetHWID_SynapseZ.UseVisualStyleBackColor = false;
            this.ResetHWID_SynapseZ.Click += new System.EventHandler(this.ResetHWID_SynapseZ_Click);
            // 
            // Info_SynapseZ
            // 
            this.Info_SynapseZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Info_SynapseZ.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Info_SynapseZ.BorderColor = System.Drawing.Color.Gray;
            this.Info_SynapseZ.BorderRadius = 20;
            this.Info_SynapseZ.BorderSize = 0;
            this.Info_SynapseZ.FlatAppearance.BorderSize = 0;
            this.Info_SynapseZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Info_SynapseZ.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.Info_SynapseZ.ForeColor = System.Drawing.SystemColors.Control;
            this.Info_SynapseZ.Location = new System.Drawing.Point(20, 205);
            this.Info_SynapseZ.Name = "Info_SynapseZ";
            this.Info_SynapseZ.Size = new System.Drawing.Size(200, 40);
            this.Info_SynapseZ.TabIndex = 7;
            this.Info_SynapseZ.Text = "Get Account Info";
            this.Info_SynapseZ.TextColor = System.Drawing.SystemColors.Control;
            this.Info_SynapseZ.UseVisualStyleBackColor = false;
            this.Info_SynapseZ.Click += new System.EventHandler(this.Info_SynapseZ_Click);
            // 
            // Redeem_SynapseZ
            // 
            this.Redeem_SynapseZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Redeem_SynapseZ.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Redeem_SynapseZ.BorderColor = System.Drawing.Color.Gray;
            this.Redeem_SynapseZ.BorderRadius = 20;
            this.Redeem_SynapseZ.BorderSize = 0;
            this.Redeem_SynapseZ.FlatAppearance.BorderSize = 0;
            this.Redeem_SynapseZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Redeem_SynapseZ.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.Redeem_SynapseZ.ForeColor = System.Drawing.SystemColors.Control;
            this.Redeem_SynapseZ.Location = new System.Drawing.Point(232, 205);
            this.Redeem_SynapseZ.Name = "Redeem_SynapseZ";
            this.Redeem_SynapseZ.Size = new System.Drawing.Size(200, 40);
            this.Redeem_SynapseZ.TabIndex = 6;
            this.Redeem_SynapseZ.Text = "Redeem Key";
            this.Redeem_SynapseZ.TextColor = System.Drawing.SystemColors.Control;
            this.Redeem_SynapseZ.UseVisualStyleBackColor = false;
            this.Redeem_SynapseZ.Click += new System.EventHandler(this.Redeem_SynapseZ_Click);
            // 
            // OpenFolder
            // 
            this.OpenFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.OpenFolder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.OpenFolder.BorderColor = System.Drawing.Color.Gray;
            this.OpenFolder.BorderRadius = 20;
            this.OpenFolder.BorderSize = 0;
            this.OpenFolder.FlatAppearance.BorderSize = 0;
            this.OpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFolder.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.OpenFolder.ForeColor = System.Drawing.SystemColors.Control;
            this.OpenFolder.Location = new System.Drawing.Point(20, 116);
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Size = new System.Drawing.Size(406, 40);
            this.OpenFolder.TabIndex = 4;
            this.OpenFolder.Text = "Open Folder";
            this.OpenFolder.TextColor = System.Drawing.SystemColors.Control;
            this.OpenFolder.UseVisualStyleBackColor = false;
            this.OpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(444, 305);
            this.Controls.Add(this.ResetHWID_SynapseZ);
            this.Controls.Add(this.Info_SynapseZ);
            this.Controls.Add(this.Redeem_SynapseZ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenFolder);
            this.Controls.Add(this.FolderList);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSPLOIT - Tools";
            this.TopMost = true;
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Label ExecutorStatus;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label Maximize;
        private System.Windows.Forms.Label CloseBtn;
        private System.Windows.Forms.Label TopBarName;
        private MSploit.RoundifiedButton OpenFolder;
        private System.Windows.Forms.ComboBox FolderList;
        private System.Windows.Forms.Label label1;
        private MSploit.RoundifiedButton Redeem_SynapseZ;
        private MSploit.RoundifiedButton Info_SynapseZ;
        private MSploit.RoundifiedButton ResetHWID_SynapseZ;
    }
}