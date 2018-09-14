using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classroom
{
    class Sylvain
    {
        //Properties
        public int X;
        public int Y;

        public Sylvain(int rX, int rY)
        {
            X = rX;
            Y = rY;
        }
        //Method
        public void Draw(Graphics G)
        {
            Font drawfont = new Font("Arial", 10);
            SolidBrush drawbrush = new SolidBrush(Color.Black);
            Image newImage = Image.FromFile( "sylvain_gandini.bmp");
            G.DrawImage(newImage, X, Y);
            G.DrawString("Sylvain Gandini",drawfont, drawbrush, X,Y+100);
        }

    }
   
}
