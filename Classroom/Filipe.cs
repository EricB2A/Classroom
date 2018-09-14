using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Classroom
{
    class Filipe
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Gender { get; private set; }
        public string HairColor { get; private set; }
        public string EyesColor { get; private set; }
        public string SkinColor { get; private set; }
        public int Heigth { get; private set; }
        public float Weigth { get; private set; }

        public int x;
        public int y;
        public string jesus = "Jesus";

        public Filipe(int p1, int p2)
        {
            x = p1;
            y = p2;

            FirstName = "Filipe";
            LastName = "LastName";
            Gender = "Male";
            HairColor = "Brown";
            EyesColor = "Brown";
            SkinColor = "White";
            Heigth = 76;
            Weigth = 50;

        }

        public void Draw(Graphics G)
        {           
            Pen pen = new Pen(Color.DarkViolet);

            G.DrawLine(pen, x, y, x+125/2, y); //x
            G.DrawLine(pen, x, y, x, y+20/2); //x
            G.DrawLine(pen, x, y+20/2, x + 125/2, y+20/2); //x
            G.DrawLine(pen, x+125/2, y, x + 125/2, y + 20/2); //x
            G.DrawLine(pen, x+50/2, y-50/2, x+50/2, y+125/2); //y
            G.DrawLine(pen, x+70/2, y-50/2, x+50/2 , y-50/2); //x
            G.DrawLine(pen, x + 70/2, y - 50/2, x + 70/2, y + 125/2); //y
            G.DrawLine(pen, x+50/2, y+125/2, x+70/2 , y+125/2); //x

            // Create string to draw.
            String drawString = jesus;

            // Create font and brush.
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            x = x + 63;
            y = y - 50;

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            // Draw string to screen.
            G.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
        }

       public void DoSomething()
        {
            jesus = "Dab Jesus";
        }
    }
}
