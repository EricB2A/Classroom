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
            this.py = v1;
            this.px = v2;
        }

        public void Draw(Graphics G)
        {
            Pen PenBlue = new Pen(Color.RoyalBlue);
            Pen PenBlack = new Pen(Color.Black);
            Pen PenRed = new Pen(Color.Red);

            // Create points that define curve.
            Point point1 = new Point(px + 60, py + 80);
            Point point2 = new Point(px + 90, py + 90);
            Point point3 = new Point(px + 120, py + 80);
            Point[] curvePoints = { point1, point2, point3 };

            G.DrawEllipse(PenBlue, px + 50, py, px + 20, py + 20);// left eyes
            G.DrawEllipse(PenBlue, px + 100, py, px + 20, py + 20); // right eyes
            G.DrawArc(PenBlack, px + 85, py + 50, px, py, 90, 180); // nose
            G.DrawCurve(PenRed, curvePoints, tension); // mouth down
            G.DrawLine(PenRed, px + 60, py + 80, px + 120, py + 80); //mouth up
        }

    }
}
