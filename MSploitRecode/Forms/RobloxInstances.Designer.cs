namespace MSploitRecode.Forms
{
    partial class RobloxInstances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RobloxInstances));
            this.TopBar = new System.Windows.Forms.Panel();
            this.ExecutorStatus = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Label();
            this.Maximize = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Label();
            this.TopBarName = new System.Windows.Forms.Label();
            this.InstanceList = new System.Windows.Forms.ComboBox();
            this.UseInstance = new MSploit.RoundifiedButton();
            this.ForceToTop = new MSploit.RoundifiedButton();
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
            this.Minimize.Visible = false;
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
            this.CloseBtn.Visible = false;
            this.CloseBtn.Click += new System.EventHandler(this.Close_Click);
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
            // InstanceList
            // 
            this.InstanceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.InstanceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InstanceList.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.InstanceList.ForeColor = System.Drawing.SystemColors.Control;
            this.InstanceList.FormattingEnabled = true;
            this.InstanceList.Location = new System.Drawing.Point(17, 60);
            this.InstanceList.Name = "InstanceList";
            this.InstanceList.Size = new System.Drawing.Size(406, 30);
            this.InstanceList.TabIndex = 3;
            // 
            // UseInstance
            // 
            this.UseInstance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.UseInstance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.UseInstance.BorderColor = System.Drawing.Color.Gray;
            this.UseInstance.BorderRadius = 20;
            this.UseInstance.BorderSize = 0;
            this.UseInstance.FlatAppearance.BorderSize = 0;
            this.UseInstance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UseInstance.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.UseInstance.ForeColor = System.Drawing.SystemColors.Control;
            this.UseInstance.Location = new System.Drawing.Point(17, 103);
            this.UseInstance.Name = "UseInstance";
            this.UseInstance.Size = new System.Drawing.Size(200, 40);
            this.UseInstance.TabIndex = 7;
            this.UseInstance.Text = "Use Instance";
            this.UseInstance.TextColor = System.Drawing.SystemColors.Control;
            this.UseInstance.UseVisualStyleBackColor = false;
            this.UseInstance.Click += new System.EventHandler(this.UseInstance_Click);
            // 
            // ForceToTop
            // 
            this.ForceToTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ForceToTop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ForceToTop.BorderColor = System.Drawing.Color.Gray;
            this.ForceToTop.BorderRadius = 20;
            this.ForceToTop.BorderSize = 0;
            this.ForceToTop.FlatAppearance.BorderSize = 0;
            this.ForceToTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForceToTop.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.ForceToTop.ForeColor = System.Drawing.SystemColors.Control;
            this.ForceToTop.Location = new System.Drawing.Point(223, 103);
            this.ForceToTop.Name = "ForceToTop";
            this.ForceToTop.Size = new System.Drawing.Size(200, 40);
            this.ForceToTop.TabIndex = 6;
            this.ForceToTop.Text = "Highlight Instance";
            this.ForceToTop.TextColor = System.Drawing.SystemColors.Control;
            this.ForceToTop.UseVisualStyleBackColor = false;
            this.ForceToTop.Click += new System.EventHandler(this.ForceToTop_Click);
            // 
            // RobloxInstances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(444, 155);
            this.Controls.Add(this.UseInstance);
            this.Controls.Add(this.ForceToTop);
            this.Controls.Add(this.InstanceList);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RobloxInstances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSPLOIT - RobloxInstances";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RobloxInstances_Load);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Label ExecutorStatus;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label Maximize;
        private System.Windows.Forms.Label CloseBtn;
        private System.Windows.Forms.Label TopBarName;
        private System.Windows.Forms.ComboBox InstanceList;
        private MSploit.RoundifiedButton ForceToTop;
        private MSploit.RoundifiedButton UseInstance;
    }
}