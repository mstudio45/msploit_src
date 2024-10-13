namespace MSploitRecode.Forms
{
    partial class UISelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UISelect));
            this.TopBar = new System.Windows.Forms.Panel();
            this.ExecutorStatus = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Label();
            this.Maximize = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.TopBarName = new System.Windows.Forms.Label();
            this.UIList = new System.Windows.Forms.ComboBox();
            this.LoadBtn = new MSploit.RoundifiedButton();
            this.SaveUI = new MSploitRecode.RJToggleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.APIList = new System.Windows.Forms.ComboBox();
            this.TopBar.SuspendLayout();
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
            // UIList
            // 
            this.UIList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.UIList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UIList.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.UIList.ForeColor = System.Drawing.SystemColors.Control;
            this.UIList.FormattingEnabled = true;
            this.UIList.Items.AddRange(new object[] {
            "Synapse X",
            "KRNL"});
            this.UIList.Location = new System.Drawing.Point(20, 80);
            this.UIList.Name = "UIList";
            this.UIList.Size = new System.Drawing.Size(406, 30);
            this.UIList.TabIndex = 3;
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.LoadBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.LoadBtn.BorderColor = System.Drawing.Color.Gray;
            this.LoadBtn.BorderRadius = 20;
            this.LoadBtn.BorderSize = 0;
            this.LoadBtn.FlatAppearance.BorderSize = 0;
            this.LoadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadBtn.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.LoadBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.LoadBtn.Location = new System.Drawing.Point(20, 228);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(406, 40);
            this.LoadBtn.TabIndex = 4;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.TextColor = System.Drawing.SystemColors.Control;
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.Load_Click);
            // 
            // SaveUI
            // 
            this.SaveUI.AutoSize = true;
            this.SaveUI.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.SaveUI.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveUI.Location = new System.Drawing.Point(80, 181);
            this.SaveUI.MinimumSize = new System.Drawing.Size(45, 22);
            this.SaveUI.Name = "SaveUI";
            this.SaveUI.OffBackColor = System.Drawing.Color.Gray;
            this.SaveUI.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.SaveUI.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.SaveUI.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.SaveUI.Size = new System.Drawing.Size(45, 22);
            this.SaveUI.TabIndex = 5;
            this.SaveUI.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(131, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Save the selected UI and API";
            // 
            // APIList
            // 
            this.APIList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.APIList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.APIList.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.APIList.ForeColor = System.Drawing.SystemColors.Control;
            this.APIList.FormattingEnabled = true;
            this.APIList.Items.AddRange(new object[] {
            "Synapse Z",
            "Seliware"});
            this.APIList.Location = new System.Drawing.Point(19, 130);
            this.APIList.Name = "APIList";
            this.APIList.Size = new System.Drawing.Size(406, 30);
            this.APIList.TabIndex = 7;
            // 
            // UISelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(444, 280);
            this.Controls.Add(this.APIList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveUI);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.UIList);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UISelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSPLOIT - UI Select";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UISelect_Load);
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
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label TopBarName;
        private System.Windows.Forms.ComboBox UIList;
        private MSploit.RoundifiedButton LoadBtn;
        private RJToggleButton SaveUI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox APIList;
    }
}