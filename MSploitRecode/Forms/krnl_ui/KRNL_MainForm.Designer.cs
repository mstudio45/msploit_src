namespace MSploitRecode.Forms.krnl_ui
{
    partial class KRNL_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KRNL_MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopBar = new System.Windows.Forms.Label();
            this.Execute = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.Button();
            this.Inject = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.ScriptList = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.InjectSecond = new System.Windows.Forms.ToolStripMenuItem();
            this.KillRoblox = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.othersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTab = new System.Windows.Forms.ToolStripMenuItem();
            this.IDETabs = new MSploitRecode.VisualStudioTabControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.TopBar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 33);
            this.panel1.TabIndex = 1;
            // 
            // Minimize
            // 
            this.Minimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(610, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(35, 33);
            this.Minimize.TabIndex = 19;
            this.Minimize.Text = "_";
            this.Minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close
            // 
            this.Close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(647, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(35, 33);
            this.Close.TabIndex = 18;
            this.Close.Text = "✕";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TopBar
            // 
            this.TopBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TopBar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopBar.ForeColor = System.Drawing.Color.White;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(679, 32);
            this.TopBar.TabIndex = 14;
            this.TopBar.Text = "KRNL";
            this.TopBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Execute
            // 
            this.Execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Execute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Execute.FlatAppearance.BorderSize = 0;
            this.Execute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Execute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Execute.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Execute.Location = new System.Drawing.Point(5, 317);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(98, 24);
            this.Execute.TabIndex = 2;
            this.Execute.Text = "EXECUTE";
            this.Execute.UseVisualStyleBackColor = false;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Clear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Clear.Location = new System.Drawing.Point(108, 317);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(98, 24);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "CLEAR";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.OpenFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.OpenFile.FlatAppearance.BorderSize = 0;
            this.OpenFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.OpenFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OpenFile.Location = new System.Drawing.Point(211, 317);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(98, 24);
            this.OpenFile.TabIndex = 4;
            this.OpenFile.Text = "OPEN FILE";
            this.OpenFile.UseVisualStyleBackColor = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SaveFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SaveFile.FlatAppearance.BorderSize = 0;
            this.SaveFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.SaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.SaveFile.ForeColor = System.Drawing.Color.White;
            this.SaveFile.Location = new System.Drawing.Point(313, 317);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(98, 24);
            this.SaveFile.TabIndex = 5;
            this.SaveFile.Text = "SAVE FILE";
            this.SaveFile.UseVisualStyleBackColor = false;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(35, 395);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 24);
            this.button5.TabIndex = 6;
            this.button5.Text = "exe FILE";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Options
            // 
            this.Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Options.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Options.FlatAppearance.BorderSize = 0;
            this.Options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Options.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Options.Location = new System.Drawing.Point(577, 317);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(98, 24);
            this.Options.TabIndex = 7;
            this.Options.Text = "OPTIONS";
            this.Options.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Options.UseVisualStyleBackColor = false;
            // 
            // Inject
            // 
            this.Inject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Inject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Inject.FlatAppearance.BorderSize = 0;
            this.Inject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Inject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Inject.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Inject.Location = new System.Drawing.Point(417, 317);
            this.Inject.Name = "Inject";
            this.Inject.Size = new System.Drawing.Size(98, 24);
            this.Inject.TabIndex = 9;
            this.Inject.Text = "INJECT";
            this.Inject.UseVisualStyleBackColor = false;
            this.Inject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DimGray;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.button9.ForeColor = System.Drawing.SystemColors.Control;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button9.Location = new System.Drawing.Point(6, 524);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(78, 25);
            this.button9.TabIndex = 16;
            this.button9.Text = "Script 1  x";
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // ScriptList
            // 
            this.ScriptList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ScriptList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScriptList.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ScriptList.ForeColor = System.Drawing.Color.White;
            this.ScriptList.HideSelection = false;
            this.ScriptList.LineColor = System.Drawing.Color.White;
            this.ScriptList.Location = new System.Drawing.Point(566, 60);
            this.ScriptList.Name = "ScriptList";
            this.ScriptList.Size = new System.Drawing.Size(109, 251);
            this.ScriptList.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(116)))), ((int)(((byte)(227)))));
            this.panel2.Location = new System.Drawing.Point(-9, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 2);
            this.panel2.TabIndex = 19;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.creditsToolStripMenuItem,
            this.toolStripMenuItem4,
            this.creditsToolStripMenuItem1,
            this.othersToolStripMenuItem1,
            this.tabsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 32);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(679, 24);
            this.menuStrip2.TabIndex = 36;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InjectSecond,
            this.KillRoblox});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // InjectSecond
            // 
            this.InjectSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.InjectSecond.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.InjectSecond.Name = "InjectSecond";
            this.InjectSecond.Size = new System.Drawing.Size(130, 22);
            this.InjectSecond.Text = "Inject";
            this.InjectSecond.Click += new System.EventHandler(this.InjectSecond_Click);
            // 
            // KillRoblox
            // 
            this.KillRoblox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.KillRoblox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.KillRoblox.Name = "KillRoblox";
            this.KillRoblox.Size = new System.Drawing.Size(130, 22);
            this.KillRoblox.Text = "Kill Roblox";
            this.KillRoblox.Click += new System.EventHandler(this.KillRoblox_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.AccessibleName = "scripthubtoolStripMenuItem1";
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem4.Text = "Games";
            // 
            // creditsToolStripMenuItem1
            // 
            this.creditsToolStripMenuItem1.AccessibleName = "scripthubtoolStripMenuItem1";
            this.creditsToolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.creditsToolStripMenuItem1.Name = "creditsToolStripMenuItem1";
            this.creditsToolStripMenuItem1.Size = new System.Drawing.Size(79, 20);
            this.creditsToolStripMenuItem1.Text = "Hot-Scripts";
            // 
            // othersToolStripMenuItem1
            // 
            this.othersToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.othersToolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.othersToolStripMenuItem1.Name = "othersToolStripMenuItem1";
            this.othersToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.othersToolStripMenuItem1.Text = "Others";
            // 
            // tabsToolStripMenuItem
            // 
            this.tabsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTab});
            this.tabsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabsToolStripMenuItem.Name = "tabsToolStripMenuItem";
            this.tabsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.tabsToolStripMenuItem.Text = "Tabs";
            // 
            // AddTab
            // 
            this.AddTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.AddTab.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddTab.Name = "AddTab";
            this.AddTab.Size = new System.Drawing.Size(117, 22);
            this.AddTab.Text = "Add Tab";
            this.AddTab.Click += new System.EventHandler(this.AddTab_Click);
            // 
            // IDETabs
            // 
            this.IDETabs.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.IDETabs.AllowDrop = true;
            this.IDETabs.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.IDETabs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.IDETabs.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
            this.IDETabs.ClosingMessage = null;
            this.IDETabs.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.IDETabs.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.IDETabs.ItemSize = new System.Drawing.Size(240, 16);
            this.IDETabs.Location = new System.Drawing.Point(5, 60);
            this.IDETabs.Name = "IDETabs";
            this.IDETabs.RecHeightOffset = 0;
            this.IDETabs.SelectedIndex = 0;
            this.IDETabs.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IDETabs.ShowClosingButton = true;
            this.IDETabs.ShowClosingMessage = false;
            this.IDETabs.Size = new System.Drawing.Size(555, 251);
            this.IDETabs.TabIndex = 1;
            this.IDETabs.TextColor = System.Drawing.Color.WhiteSmoke;
            // 
            // KRNL_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(679, 345);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ScriptList);
            this.Controls.Add(this.IDETabs);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.Inject);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KRNL_MainForm";
            this.Text = "KRNL";
            this.Load += new System.EventHandler(this.KRNL_MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Options;
        private System.Windows.Forms.Button Inject;
        private System.Windows.Forms.Button button9;
        private VisualStudioTabControl IDETabs;
        private System.Windows.Forms.TreeView ScriptList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label TopBar;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem InjectSecond;
        private System.Windows.Forms.ToolStripMenuItem KillRoblox;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem othersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tabsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddTab;
    }
}