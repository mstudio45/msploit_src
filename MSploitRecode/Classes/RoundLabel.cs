using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSploitRecode.Classes
{
    internal class RoundLabel
    {
        private Label label;
        private int cornerRadius;
        private Color backColor;

        public RoundLabel(Label label, int cornerRadius, Color backColor)
        {
            this.label = label;
            this.cornerRadius = cornerRadius;
            this.backColor = backColor;

            this.label.BackColor = Color.Transparent;
            this.label.Paint += Label_Paint;
        }

        private void Label_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle rect = new Rectangle(0, 0, label.Width, label.Height);

                path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseAllFigures();

                using (Brush brush = new SolidBrush(backColor))
                    e.Graphics.FillPath(brush, path);

                TextRenderer.DrawText(e.Graphics, label.Text, label.Font, rect, label.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }
    }
}
