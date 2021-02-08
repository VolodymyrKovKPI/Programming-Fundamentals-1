using System.Drawing;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        private Bitmap _bitmap;
        private Graphics _graphics;

        public Form1()
        {
            InitializeComponent();

            /*
            PointF[] startingPoints = //Triangle top down
            {
                new PointF(Canvas.Width/2, 0),
                new PointF(0, Canvas.Height),
                new PointF(Canvas.Width, Canvas.Height),
            };
            */
        }

        private void DrawTriangle(int iterations, PointF topPoint, PointF leftPoint, PointF rightPoint)
        {
            if (iterations == 0)
            {
                PointF[] points = { topPoint, rightPoint, leftPoint };

                _graphics.FillPolygon(Brushes.DarkRed, points);
            }

            else
            {
                PointF leftMiddle = CalculateMidPoint(topPoint, leftPoint);
                PointF rightMiddle = CalculateMidPoint(topPoint, rightPoint);
                PointF topMiddle = CalculateMidPoint(leftPoint, rightPoint);

                DrawTriangle(iterations - 1, topPoint, leftMiddle, rightMiddle);
                DrawTriangle(iterations - 1, leftMiddle, leftPoint, topMiddle);
                DrawTriangle(iterations - 1, rightMiddle, topMiddle, rightPoint);
            }

        }

        private PointF CalculateMidPoint(PointF pt1, PointF pt2) =>
            new PointF((pt1.X + pt2.X) / 2, (pt1.Y + pt2.Y) / 2);

        private void button1_Click(object sender, System.EventArgs e)
        {
            int rec = 5;

            rec = int.Parse(Recursion.Text);
            
            if (rec == 0)
                rec = 5;

            _bitmap = new Bitmap(Canvas.Width, Canvas.Height);
            _graphics = Graphics.FromImage(_bitmap);
            Canvas.Image = _bitmap;

            PointF[] startingPoints =   //triangle top up
            {
                new PointF(Canvas.Width / 2, Canvas.Height), 
                new PointF(0, 0), 
                new PointF(Canvas.Width, 0)
            };

            DrawTriangle(rec, startingPoints[0], startingPoints[1], startingPoints[2]);
        }
    }
}
