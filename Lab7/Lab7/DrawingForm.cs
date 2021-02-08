using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7
{
    public partial class DrawingForm : Form
    {
        private Graphics _graphics;
        private Pen _pen;

        private Dictionary<string, Point[]> _lettersDictionary = new Dictionary<string, Point[]>();

        public DrawingForm()
        {
            InitializeComponent();
            InitCanvas();
        }

        private void InitCanvas()
        {
            Bitmap bmp = new Bitmap(Canvas.Width, Canvas.Height);
            Canvas.Image = bmp;
            _graphics = Graphics.FromImage(bmp);
            _pen = new Pen(Color.Wheat, 7);

            int initialPositionY = bmp.Height / 4;
            int maxHeight = initialPositionY - 50;
            int minHeight = initialPositionY + 50;

            SetLetters(maxHeight, minHeight);

            string[] nameLetter = {"V", "O", "L", "O", "D", "Y", "M", "Y", "R", 
                "K", "O", "V", "I", "E", "S", "H", "N", "I", "K", "O", "V" };
            int offset = 0;
            foreach (var letter in nameLetter)
            {
                DrawLetter(offset, letter);
                offset += 80;
            }

        }

        private void SetLetters(int maxYPos, int minYPos)
        {

            Point[] pointsV =
            {
                new Point(10, maxYPos),
                new Point(35, minYPos),
                new Point(60, maxYPos),
            };

            Point[] pointsO =
            {
                new Point(10, maxYPos), 
                new Point(10, minYPos), 
                new Point(60, minYPos), 
                new Point(60, maxYPos), 
            };

            Point[] pointsL =
            {
                new Point(10, maxYPos), 
                new Point(10, minYPos), 
                new Point(60, minYPos), 
            };

            Point[] pointsD =
            {
                new Point(10, maxYPos),
                new Point(10, minYPos), 
                new Point(60, maxYPos + 50), 
            };
            Point[] pointsY =
            {
                new Point(10, maxYPos), 
                new Point(35, maxYPos + 50), 
                new Point(35, minYPos), 
                new Point(35, maxYPos + 50), 
                new Point(60, maxYPos), 
            };
            Point[] pointsM =
            {
                new Point(10, minYPos), 
                new Point(10, maxYPos), 
                new Point(35, maxYPos + 50), 
                new Point(60, maxYPos), 
                new Point(60, minYPos), 
            };
            Point[] pointsR =
            {
                new Point(10, minYPos), 
                new Point(10, maxYPos), 
                new Point(60, maxYPos + 25), 
                new Point(10, maxYPos + 50),
                new Point(60, minYPos),
            };

            Point[] pointsK =
            {
                new Point(10, maxYPos),
                new Point(10, minYPos),
                new Point(10, maxYPos + 50),
                new Point(60, maxYPos),
                new Point(10, maxYPos + 50),
                new Point(60, minYPos), 
            };

            Point[] pointsI =
            {
                new Point(10, maxYPos), 
                new Point(10, minYPos), 
            };

            Point[] pointsE =
            {
                new Point(50, maxYPos), 
                new Point(10, maxYPos), 
                new Point(10, maxYPos + 50), 
                new Point(35, maxYPos + 50),
                new Point(10, maxYPos + 50),
                new Point(10, minYPos), 
                new Point(50, minYPos), 
            };

            Point[] pointsS =
            {
                new Point(35, maxYPos), 
                new Point(10, maxYPos), 
                new Point(10, maxYPos + 50), 
                new Point(35, maxYPos+50), 
                new Point(35, minYPos), 
                new Point(10, minYPos), 
            };

            Point[] pointsH =
            {
                new Point(10, maxYPos), 
                new Point(10, minYPos), 
                new Point(10, maxYPos+50), 
                new Point(60, maxYPos+50), 
                new Point(60, minYPos), 
                new Point(60,maxYPos), 
            };

            Point[] pointsN =
            {
                new Point(10, minYPos),
                new Point(10, maxYPos),
                new Point(60, minYPos),
                new Point(60, maxYPos),
            };

            _lettersDictionary.Add("V", pointsV);
            _lettersDictionary.Add("O", pointsO);
            _lettersDictionary.Add("L", pointsL);
            _lettersDictionary.Add("D", pointsD);
            _lettersDictionary.Add("Y", pointsY);
            _lettersDictionary.Add("M", pointsM);
            _lettersDictionary.Add("R", pointsR);
            _lettersDictionary.Add("K", pointsK);
            _lettersDictionary.Add("I", pointsI);
            _lettersDictionary.Add("E", pointsE);
            _lettersDictionary.Add("S", pointsS);
            _lettersDictionary.Add("H", pointsH);
            _lettersDictionary.Add("N", pointsN);
        }

        private void DrawLetter(int xOffset, string letter)
        {
            Point[] letterPoints = (Point[])_lettersDictionary[letter].Clone(); //required to avoid reference
            bool isCircled = letter == "O" || letter == "D"; //flag if you need to return to pt[0]

            for (int i = 0; i < letterPoints.Length; i++)
                letterPoints[i].X += xOffset;

            for (int i = 0; i < letterPoints.Length; i++)
            {
                Point pt1 = letterPoints[i];
                Point pt2;
                if (i == letterPoints.Length - 1 && !isCircled)
                    break;
                
                if(i == letterPoints.Length - 1 && isCircled)
                    pt2 = letterPoints[0];
                else
                    pt2 = letterPoints[i + 1];

                _graphics.DrawLine(_pen, pt1, pt2);
            }
        }
    }
}
