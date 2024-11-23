using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSploitRecode.Classes
{
    internal class Fade
    {
        private Form form;

        public Fade(Form form)
        {
            this.form = form;
            this.form.Hide();
        }

        public async Task FadeIn()
        {
            this.form.Show();

            for (uint i = 0u; i < 5; i++)
            {
                this.form.Opacity += 0.2;
                await Task.Delay(20);
            }

            this.form.Opacity = 1;
        }
        public async Task FadeOut()
        {
            for (uint i = 0u; i < 5; i++)
            {
                this.form.Opacity -= 0.2;
                await Task.Delay(20);
            }

            await Task.Delay(500);
            this.form.Hide();
        }
    }
}
