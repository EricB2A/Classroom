using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Classroom
{
    class Jeremy
    {
        public int px;
        public int py;

        float tension = 1.0F;

        public string firstname;
        public string lastname;
        public string gender;
        public int age;
        public float size;
        public string haircolor;
        public string eyescolor;
        public string color;
        public string Country;
        public string City;
        private int v1;
        private int v2;

        public Jeremy(int v1, int v2)
        {
            this.px = v1; //640
            this.py = v2; //10
        }

        public void Draw(Graphics G)
        {
            // Create color pen.
            Pen PenBlue = new Pen(Color.RoyalBlue);
            Pen PenBlack = new Pen(Color.Black);
            Pen PenRed = new Pen(Color.Red);

            // Create string to draw.
            String Text = "Jeremy";

            // Create font and brush.
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;

            // Create points that define curve.
            Point point1 = new Point(px + 25, py + 90); //point of mouth left
            Point point2 = new Point(px + 45, py + 100); //point of mouth center
            Point point3 = new Point(px + 70, py + 90); //point of mouth right
            Point[] curvePoints = { point1, point2, point3 }; // Array point of mouth

            // Draw
            G.DrawEllipse(PenBlue, px, py, 40, 40);// left eyes
            G.DrawEllipse(PenBlue, px + 50, py, 40, 40); // right eyes
            G.DrawArc(PenBlack, px + 40, py + 50, 10, 10, 90, 180); // nose
            G.DrawCurve(PenRed, curvePoints, tension); // mouth down
            G.DrawLine(PenRed, px + 25 , py + 90, px + 70, py + 90); //mouth up
            G.DrawString(Text, drawFont, drawBrush, px+45, py + 110, drawFormat);// Text Jeremy
        }

        public void DoSomething()
        {
            /*Pen PenRed = new Pen(Color.Red);

            // Create points that define curve.
            Point point1 = new Point(px + 25, py + 100); //point of mouth left
            Point point2 = new Point(px + 45, py + 90); //point of mouth center
            Point point3 = new Point(px + 70, py + 100); //point of mouth right
            Point[] curvePoints = { point1, point2, point3 }; // Array point of mouth

            G.DrawLine(PenRed, px + 25, py + 90, px + 70, py + 90); //mouth up*/
        }
    }
}
