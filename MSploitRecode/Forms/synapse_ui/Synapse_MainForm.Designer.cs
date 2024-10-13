namespace MSploitRecode.Forms.synapse_ui
{
    partial class Synapse_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Synapse_MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Maximize = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.TopBar = new System.Windows.Forms.Label();
            this.Execute = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.ExecuteFile = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.Button();
            this.ScriptHub = new System.Windows.Forms.Button();
            this.Inject = new System.Windows.Forms.Button();
            this.ScriptList = new System.Windows.Forms.ListBox();
            this.button9 = new System.Windows.Forms.Button();
            this.IDETabs = new MSploitRecode.VisualStudioTabControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Maximize);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.TopBar);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 35);
            this.panel1.TabIndex = 1;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DimGray;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button10.ForeColor = System.Drawing.SystemColors.Control;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button10.Location = new System.Drawing.Point(48, 10);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(25, 22);
            this.button10.TabIndex = 17;
            this.button10.Text = "+";
            this.button10.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Maximize
            // 
            this.Maximize.AutoSize = true;
            this.Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximize.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.Maximize.ForeColor = System.Drawing.SystemColors.Control;
            this.Maximize.Location = new System.Drawing.Point(892, 0);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(23, 20);
            this.Maximize.TabIndex = 7;
            this.Maximize.Text = "M";
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.Minimize.ForeColor = System.Drawing.SystemColors.Control;
            this.Minimize.Location = new System.Drawing.Point(862, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(24, 20);
            this.Minimize.TabIndex = 3;
            this.Minimize.Text = "🗕";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.Close.ForeColor = System.Drawing.SystemColors.Control;
            this.Close.Location = new System.Drawing.Point(920, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(18, 20);
            this.Close.TabIndex = 1;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // TopBar
            // 
            this.TopBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopBar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.TopBar.ForeColor = System.Drawing.SystemColors.Control;
            this.TopBar.Location = new System.Drawing.Point(6, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(932, 32);
            this.TopBar.TabIndex = 6;
            this.TopBar.Text = "Synapse X - v2.20.7b";
            this.TopBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Execute
            // 
            this.Execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Execute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Execute.FlatAppearance.BorderSize = 0;
            this.Execute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Execute.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Execute.ForeColor = System.Drawing.Color.White;
            this.Execute.Location = new System.Drawing.Point(6, 356);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(105, 38);
            this.Execute.TabIndex = 2;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = false;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(117, 356);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(105, 38);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.OpenFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.OpenFile.FlatAppearance.BorderSize = 0;
            this.OpenFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFile.ForeColor = System.Drawing.Color.White;
            this.OpenFile.Location = new System.Drawing.Point(228, 356);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(105, 38);
            this.OpenFile.TabIndex = 4;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SaveFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SaveFile.FlatAppearance.BorderSize = 0;
            this.SaveFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.SaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFile.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveFile.ForeColor = System.Drawing.Color.White;
            this.SaveFile.Location = new System.Drawing.Point(450, 356);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(105, 38);
            this.SaveFile.TabIndex = 5;
            this.SaveFile.Text = "Save File";
            this.SaveFile.UseVisualStyleBackColor = false;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // ExecuteFile
            // 
            this.ExecuteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ExecuteFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ExecuteFile.FlatAppearance.BorderSize = 0;
            this.ExecuteFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.ExecuteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteFile.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteFile.ForeColor = System.Drawing.Color.White;
            this.ExecuteFile.Location = new System.Drawing.Point(339, 356);
            this.ExecuteFile.Name = "ExecuteFile";
            this.ExecuteFile.Size = new System.Drawing.Size(105, 38);
            this.ExecuteFile.TabIndex = 6;
            this.ExecuteFile.Text = "Execute File";
            this.ExecuteFile.UseVisualStyleBackColor = false;
            this.ExecuteFile.Click += new System.EventHandler(this.ExecuteFile_Click);
            // 
            // Options
            // 
            this.Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Options.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Options.FlatAppearance.BorderSize = 0;
            this.Options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Options.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options.ForeColor = System.Drawing.Color.White;
            this.Options.Location = new System.Drawing.Point(561, 356);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(105, 38);
            this.Options.TabIndex = 7;
            this.Options.Text = "Options";
            this.Options.UseVisualStyleBackColor = false;
            // 
            // ScriptHub
            // 
            this.ScriptHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ScriptHub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ScriptHub.FlatAppearance.BorderSize = 0;
            this.ScriptHub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.ScriptHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScriptHub.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptHub.ForeColor = System.Drawing.Color.White;
            this.ScriptHub.Location = new System.Drawing.Point(827, 356);
            this.ScriptHub.Name = "ScriptHub";
            this.ScriptHub.Size = new System.Drawing.Size(105, 38);
            this.ScriptHub.TabIndex = 8;
            this.ScriptHub.Text = "Script Hub";
            this.ScriptHub.UseVisualStyleBackColor = false;
            // 
            // Inject
            // 
            this.Inject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Inject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Inject.FlatAppearance.BorderSize = 0;
            this.Inject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.Inject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inject.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inject.ForeColor = System.Drawing.Color.White;
            this.Inject.Location = new System.Drawing.Point(716, 356);
            this.Inject.Name = "Inject";
            this.Inject.Size = new System.Drawing.Size(105, 38);
            this.Inject.TabIndex = 9;
            this.Inject.Text = "Attach";
            this.Inject.UseVisualStyleBackColor = false;
            this.Inject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // ScriptList
            // 
            this.ScriptList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ScriptList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScriptList.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptList.ForeColor = System.Drawing.SystemColors.Control;
            this.ScriptList.FormattingEnabled = true;
            this.ScriptList.ItemHeight = 20;
            this.ScriptList.Location = new System.Drawing.Point(804, 44);
            this.ScriptList.Name = "ScriptList";
            this.ScriptList.Size = new System.Drawing.Size(128, 300);
            this.ScriptList.TabIndex = 14;
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
            // IDETabs
            // 
            this.IDETabs.ActiveColor = System.Drawing.Color.DimGray;
            this.IDETabs.AllowDrop = true;
            this.IDETabs.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.IDETabs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.IDETabs.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
            this.IDETabs.ClosingMessage = null;
            this.IDETabs.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.IDETabs.HorizontalLineColor = System.Drawing.Color.DimGray;
            this.IDETabs.ItemSize = new System.Drawing.Size(240, 16);
            this.IDETabs.Location = new System.Drawing.Point(6, 41);
            this.IDETabs.Name = "IDETabs";
            this.IDETabs.RecHeightOffset = 0;
            this.IDETabs.SelectedIndex = 0;
            this.IDETabs.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IDETabs.ShowClosingButton = true;
            this.IDETabs.ShowClosingMessage = false;
            this.IDETabs.Size = new System.Drawing.Size(792, 309);
            this.IDETabs.TabIndex = 1;
            this.IDETabs.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // Synapse_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(936, 400);
            this.Controls.Add(this.IDETabs);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.ScriptList);
            this.Controls.Add(this.Inject);
            this.Controls.Add(this.ScriptHub);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.ExecuteFile);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Synapse_MainForm";
            this.Text = "Synapse X";
            this.Load += new System.EventHandler(this.Synapse_MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Maximize;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label TopBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Button ExecuteFile;
        private System.Windows.Forms.Button Options;
        private System.Windows.Forms.Button ScriptHub;
        private System.Windows.Forms.Button Inject;
        private System.Windows.Forms.ListBox ScriptList;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private VisualStudioTabControl IDETabs;
    }
}