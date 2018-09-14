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
        public bool t;
        public Sylvain(int rX, int rY)
        {
            X = rX;
            Y = rY;
            t = false;
        }
        //Method
        public void Draw(Graphics G)
        {
            if (t == true)
            {
                Font drawfont = new Font("Arial", 10);
                SolidBrush drawbrush = new SolidBrush(Color.Black);
                G.DrawString("Sylvain Gandini", drawfont, drawbrush, X, Y + 100);
            }
            else
            {
                Font drawfont = new Font("Arial", 10);
                SolidBrush drawbrush = new SolidBrush(Color.Black);
                G.DrawString("Délégué", drawfont, drawbrush, X, Y + 100);
            }
            Image newImage = Image.FromFile( "sylvain_gandini.bmp");
            G.DrawImage(newImage, X, Y);
           
        }
        public void DoSomething()
        {
            if (t == false)
            {
                t = true;
            }
            else t = false;
        }

    }
   
}
