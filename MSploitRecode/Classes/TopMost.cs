using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSploitRecode.Classes
{
    internal class TopMost
    {
        private Form form;
        private bool TopMostEnabled;

        public TopMost(Form form)
        {
            this.form = form;

            if (Data.SettingsLoaded)
                TopMostEnabled = (bool)Data.Settings.TopMost;

            this.form.TopMost = TopMostEnabled;
            this.form.VisibleChanged += (s, e) => {
                if (this.form.Visible)
                    this.Enable();
                else
                    this.Disable();
            };
        }

        public void MessageBoxShow(string text, string caption)
        {
            if (this.form != null)
                this.form.TopMost = false;
            MessageBox.Show(text, caption);
            if (this.form != null)
                this.form.TopMost = TopMostEnabled;
        }

        public void MessageBoxShow(string text, string caption, MessageBoxButtons buttons)
        {
            if (this.form != null)
                this.form.TopMost = false;
            MessageBox.Show(text, caption, buttons);
            if (this.form != null)
                this.form.TopMost = TopMostEnabled;
        }

        public void MessageBoxShow(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            if (this.form != null)
                this.form.TopMost = false;
            MessageBox.Show(text, caption, buttons, icon);
            if (this.form != null)
                this.form.TopMost = TopMostEnabled;
        }

        public void MessageBoxShow(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options, bool displayHelpButton)
        {
            if (this.form != null)
                this.form.TopMost = false;
            MessageBox.Show(text, caption, buttons, icon, defaultButton, options, displayHelpButton);
            if (this.form != null)
                this.form.TopMost = TopMostEnabled;
        }

        public void Disable()
        {
            if (Data.SettingsLoaded)
                TopMostEnabled = (bool)Data.Settings.TopMost;

            if (this.form != null)
                this.form.TopMost = false; 
        }

        public void Enable()
        {
            if (Data.SettingsLoaded)
                TopMostEnabled = (bool)Data.Settings.TopMost;

            if (this.form != null)
                this.form.TopMost = TopMostEnabled; 
        }
    }
}
