namespace MSploitRecode.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.TopBar = new System.Windows.Forms.Panel();
            this.ExecutorStatus = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Label();
            this.Maximize = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Label();
            this.TopBarName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OpenTools = new MSploit.RoundifiedButton();
            this.OpenScriptsUI = new MSploit.RoundifiedButton();
            this.MultiInstance = new MSploitRecode.RJToggleButton();
            this.AutoAttach = new MSploitRecode.RJToggleButton();
            this.Restart = new MSploit.RoundifiedButton();
            this.Save = new MSploit.RoundifiedButton();
            this.DeloadUI = new MSploit.RoundifiedButton();
            this.OnTop = new MSploitRecode.RJToggleButton();
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
            this.TopBar.Size = new System.Drawing.Size(663, 51);
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
            this.Minimize.Location = new System.Drawing.Point(579, 14);
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
            this.Maximize.Location = new System.Drawing.Point(603, 14);
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
            this.CloseBtn.Location = new System.Drawing.Point(629, 14);
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
            this.TopBarName.Size = new System.Drawing.Size(80, 22);
            this.TopBarName.TabIndex = 0;
            this.TopBarName.Text = "msploit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(63, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Windows on top (restart required)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(63, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Auto-Attach";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(63, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Multi Instance";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(341, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tools";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Settings";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenTools
            // 
            this.OpenTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.OpenTools.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.OpenTools.BorderColor = System.Drawing.Color.Gray;
            this.OpenTools.BorderRadius = 20;
            this.OpenTools.BorderSize = 0;
            this.OpenTools.FlatAppearance.BorderSize = 0;
            this.OpenTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenTools.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.OpenTools.ForeColor = System.Drawing.SystemColors.Control;
            this.OpenTools.Location = new System.Drawing.Point(345, 183);
            this.OpenTools.Name = "OpenTools";
            this.OpenTools.Size = new System.Drawing.Size(305, 40);
            this.OpenTools.TabIndex = 20;
            this.OpenTools.Text = "Open Tools";
            this.OpenTools.TextColor = System.Drawing.SystemColors.Control;
            this.OpenTools.UseVisualStyleBackColor = false;
            this.OpenTools.Click += new System.EventHandler(this.ToolsUI_Click);
            // 
            // OpenScriptsUI
            // 
            this.OpenScriptsUI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.OpenScriptsUI.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.OpenScriptsUI.BorderColor = System.Drawing.Color.Gray;
            this.OpenScriptsUI.BorderRadius = 20;
            this.OpenScriptsUI.BorderSize = 0;
            this.OpenScriptsUI.FlatAppearance.BorderSize = 0;
            this.OpenScriptsUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenScriptsUI.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.OpenScriptsUI.ForeColor = System.Drawing.SystemColors.Control;
            this.OpenScriptsUI.Location = new System.Drawing.Point(345, 137);
            this.OpenScriptsUI.Name = "OpenScriptsUI";
            this.OpenScriptsUI.Size = new System.Drawing.Size(305, 40);
            this.OpenScriptsUI.TabIndex = 19;
            this.OpenScriptsUI.Text = "Open Scripts UI";
            this.OpenScriptsUI.TextColor = System.Drawing.SystemColors.Control;
            this.OpenScriptsUI.UseVisualStyleBackColor = false;
            this.OpenScriptsUI.Click += new System.EventHandler(this.OpenScriptsUI_Click);
            // 
            // MultiInstance
            // 
            this.MultiInstance.AutoSize = true;
            this.MultiInstance.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.MultiInstance.ForeColor = System.Drawing.SystemColors.Control;
            this.MultiInstance.Location = new System.Drawing.Point(11, 147);
            this.MultiInstance.MinimumSize = new System.Drawing.Size(45, 22);
            this.MultiInstance.Name = "MultiInstance";
            this.MultiInstance.OffBackColor = System.Drawing.Color.Gray;
            this.MultiInstance.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.MultiInstance.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.MultiInstance.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.MultiInstance.Size = new System.Drawing.Size(45, 22);
            this.MultiInstance.TabIndex = 15;
            this.MultiInstance.UseVisualStyleBackColor = true;
            this.MultiInstance.Visible = false;
            // 
            // AutoAttach
            // 
            this.AutoAttach.AutoSize = true;
            this.AutoAttach.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.AutoAttach.ForeColor = System.Drawing.SystemColors.Control;
            this.AutoAttach.Location = new System.Drawing.Point(11, 119);
            this.AutoAttach.MinimumSize = new System.Drawing.Size(45, 22);
            this.AutoAttach.Name = "AutoAttach";
            this.AutoAttach.OffBackColor = System.Drawing.Color.Gray;
            this.AutoAttach.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.AutoAttach.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.AutoAttach.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.AutoAttach.Size = new System.Drawing.Size(45, 22);
            this.AutoAttach.TabIndex = 13;
            this.AutoAttach.UseVisualStyleBackColor = true;
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Restart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Restart.BorderColor = System.Drawing.Color.Gray;
            this.Restart.BorderRadius = 20;
            this.Restart.BorderSize = 0;
            this.Restart.FlatAppearance.BorderSize = 0;
            this.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restart.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.Restart.ForeColor = System.Drawing.SystemColors.Control;
            this.Restart.Location = new System.Drawing.Point(501, 91);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(149, 40);
            this.Restart.TabIndex = 12;
            this.Restart.Text = "Restart";
            this.Restart.TextColor = System.Drawing.SystemColors.Control;
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Save.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Save.BorderColor = System.Drawing.Color.Gray;
            this.Save.BorderRadius = 20;
            this.Save.BorderSize = 0;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.Save.ForeColor = System.Drawing.SystemColors.Control;
            this.Save.Location = new System.Drawing.Point(12, 183);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(324, 40);
            this.Save.TabIndex = 11;
            this.Save.Text = "Save";
            this.Save.TextColor = System.Drawing.SystemColors.Control;
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // DeloadUI
            // 
            this.DeloadUI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.DeloadUI.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.DeloadUI.BorderColor = System.Drawing.Color.Gray;
            this.DeloadUI.BorderRadius = 20;
            this.DeloadUI.BorderSize = 0;
            this.DeloadUI.FlatAppearance.BorderSize = 0;
            this.DeloadUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeloadUI.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.DeloadUI.ForeColor = System.Drawing.SystemColors.Control;
            this.DeloadUI.Location = new System.Drawing.Point(345, 91);
            this.DeloadUI.Name = "DeloadUI";
            this.DeloadUI.Size = new System.Drawing.Size(150, 40);
            this.DeloadUI.TabIndex = 10;
            this.DeloadUI.Text = "Switch API/UI";
            this.DeloadUI.TextColor = System.Drawing.SystemColors.Control;
            this.DeloadUI.UseVisualStyleBackColor = false;
            this.DeloadUI.Click += new System.EventHandler(this.DeloadUI_Click);
            // 
            // OnTop
            // 
            this.OnTop.AutoSize = true;
            this.OnTop.Checked = true;
            this.OnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OnTop.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.OnTop.ForeColor = System.Drawing.SystemColors.Control;
            this.OnTop.Location = new System.Drawing.Point(11, 91);
            this.OnTop.MinimumSize = new System.Drawing.Size(45, 22);
            this.OnTop.Name = "OnTop";
            this.OnTop.OffBackColor = System.Drawing.Color.Gray;
            this.OnTop.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.OnTop.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.OnTop.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.OnTop.Size = new System.Drawing.Size(45, 22);
            this.OnTop.TabIndex = 8;
            this.OnTop.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(662, 235);
            this.Controls.Add(this.OpenTools);
            this.Controls.Add(this.OpenScriptsUI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MultiInstance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AutoAttach);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.DeloadUI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OnTop);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Settings_Load);
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
        private System.Windows.Forms.Label label2;
        private RJToggleButton OnTop;
        private MSploit.RoundifiedButton DeloadUI;
        private MSploit.RoundifiedButton Save;
        private MSploit.RoundifiedButton Restart;
        private System.Windows.Forms.Label label1;
        private RJToggleButton AutoAttach;
        private System.Windows.Forms.Label label3;
        private RJToggleButton MultiInstance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MSploit.RoundifiedButton OpenScriptsUI;
        private MSploit.RoundifiedButton OpenTools;
    }
}