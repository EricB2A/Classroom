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
            Pen P = new Pen(Color.Red);
            Image newImage = Image.FromFile( "sylvain_gandini.bmp");
            G.DrawImage(newImage, X, Y);           
        }

    }
   
}
