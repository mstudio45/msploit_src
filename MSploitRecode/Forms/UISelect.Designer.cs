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
            this.CloseBtn = new System.Windows.Forms.Label();
            this.TopBarName = new System.Windows.Forms.Label();
            this.UIList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.APIList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenTools = new MSploitRecode.RJToggleButton();
            this.SaveUI = new MSploitRecode.RJToggleButton();
            this.LoadBtn = new MSploit.RoundifiedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.UIList.Location = new System.Drawing.Point(17, 86);
            this.UIList.Name = "UIList";
            this.UIList.Size = new System.Drawing.Size(406, 30);
            this.UIList.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(75, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Save these options";
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
            this.APIList.Location = new System.Drawing.Point(17, 144);
            this.APIList.Name = "APIList";
            this.APIList.Size = new System.Drawing.Size(406, 30);
            this.APIList.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(299, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Open Tools UI";
            // 
            // OpenTools
            // 
            this.OpenTools.AutoSize = true;
            this.OpenTools.Checked = true;
            this.OpenTools.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OpenTools.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.OpenTools.ForeColor = System.Drawing.SystemColors.Control;
            this.OpenTools.Location = new System.Drawing.Point(247, 184);
            this.OpenTools.MinimumSize = new System.Drawing.Size(45, 22);
            this.OpenTools.Name = "OpenTools";
            this.OpenTools.OffBackColor = System.Drawing.Color.Gray;
            this.OpenTools.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.OpenTools.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.OpenTools.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.OpenTools.Size = new System.Drawing.Size(45, 22);
            this.OpenTools.TabIndex = 8;
            this.OpenTools.UseVisualStyleBackColor = true;
            // 
            // SaveUI
            // 
            this.SaveUI.AutoSize = true;
            this.SaveUI.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.SaveUI.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveUI.Location = new System.Drawing.Point(24, 184);
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
            this.LoadBtn.Location = new System.Drawing.Point(17, 217);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(406, 40);
            this.LoadBtn.TabIndex = 4;
            this.LoadBtn.Text = "Continue";
            this.LoadBtn.TextColor = System.Drawing.SystemColors.Control;
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.Load_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "UI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 13.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(9, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "API:";
            // 
            // UISelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(444, 273);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenTools);
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
            this.Text = "UI Select";
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
        private System.Windows.Forms.Label CloseBtn;
        private System.Windows.Forms.Label TopBarName;
        private System.Windows.Forms.ComboBox UIList;
        private MSploit.RoundifiedButton LoadBtn;
        private RJToggleButton SaveUI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox APIList;
        private System.Windows.Forms.Label label2;
        private RJToggleButton OpenTools;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}