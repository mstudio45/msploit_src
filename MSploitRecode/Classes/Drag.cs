using System.Drawing;
using System.Windows.Forms;

namespace MSploitRecode.Classes
{
    internal class Drag
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private Form form;

        // Panel //
        private Panel panel;
        public Drag(Form form, Panel panel) 
        {
            this.form = form;
            this.panel = panel;

            this.panel.MouseMove += Panel_MouseMove;
            this.panel.MouseDown += Panel_MouseDown;
            this.panel.MouseUp += Panel_MouseUp;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point point = this.panel.PointToScreen(e.Location);
                this.form.Location = new System.Drawing.Point(point.X - this.startPoint.X, point.Y - this.startPoint.Y);
            }
        }
        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            this.dragging = false;
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            this.dragging = true;
            this.startPoint = new Point(e.X, e.Y);
        }

        // Label //
        private Label label;

        public Drag(Form form, Label label)
        {
            this.form = form;
            this.label = label;

            this.label.MouseMove += Label_MouseMove;
            this.label.MouseDown += Label_MouseDown;
            this.label.MouseUp += Label_MouseUp;
        }

        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point point = this.label.PointToScreen(e.Location);
                this.form.Location = new System.Drawing.Point(point.X - this.startPoint.X, point.Y - this.startPoint.Y);
            }
        }
        private void Label_MouseUp(object sender, MouseEventArgs e)
        {
            this.dragging = false;
        }

        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            this.dragging = true;
            this.startPoint = new Point(e.X, e.Y);
        }
    }
}
