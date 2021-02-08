using System.Drawing;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DrawSquare();
        }

        private void DrawSquare()
        {
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            picture.Image = bmp;
            Graphics graphics = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Red, width: 2);

            float x1 = 0;
            float y1 = 0;

            float x2 = 500;
            float y2 = 0;

            float x3 = 500;
            float y3 = 500;

            float x4 = 0;
            float y4 = 500;

            for (int i = 0; i < 50; i++)
            {
                float p = 0.08f;

                graphics.DrawLine(pen, x1, y1, x2, y2);
                graphics.DrawLine(pen, x2, y2, x3, y3);
                graphics.DrawLine(pen, x3, y3, x4, y4);
                graphics.DrawLine(pen, x4, y4, x1, y1);

                x1 += (x2 - x1) * p;
                y1 += (y2 - y1) * p;

                x2 += (x3 - x2) * p;
                y2 += (y3 - y2) * p;

                x3 += (x4 - x3) * p;
                y3 += (y4 - y3) * p;

                x4 += (x1 - x4) * p;
                y4 += (y1 - y4) * p;
            }
        }
    }
}
