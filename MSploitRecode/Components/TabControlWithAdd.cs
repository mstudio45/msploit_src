using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSploitRecode
{
    public partial class TabControlWithAdd : UserControl
    {
        public TabControlWithAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add("Tab " + (tabControl1.TabPages.Count + 1));
        }
    }
}
