using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class Dylan
    {
        public int px;
        public int py;

        public string firstname;
        public string surname;
        public bool gender;
        public DateTime birthday;
        public float size;
        public float weight;
        public string eyecolor;
        public string haircolor;
        public string nationality;
        public string hobbies;

        public Dylan(int x, int y)
        {
            px = x;
            py = y;
        }

        public void draw(Graphics G)
        {
            Pen P = new Pen(Color.Black);
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.OrangeRed);
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();

            G.DrawEllipse(P, px, py, 150, 150); //Head
            G.DrawEllipse(P, px + 17, py + 40, 50, 25); //Left eye                  
            G.DrawEllipse(P, px + 30, py + 40, 25, 25); //Left eye
            G.DrawEllipse(P, px + 87, py + 40, 50, 25); //Right eye  
            G.DrawEllipse(P, px + 100, py + 40, 25, 25); //Right eye
            G.DrawEllipse(P, px + 50, py + 100, 50, 25); //Mouth  
            G.DrawEllipse(P, px + 45, py + 95, 60, 35); //Mouth
            G.DrawLine(P, px + 51, py + 113, px + 100, py + 113); //Tooth 
            G.DrawLine(P, px + 60, py + 104, px + 60, py + 123); //Tooth 
            G.DrawLine(P, px + 70, py + 100, px + 70, py + 125); //Tooth 
            G.DrawLine(P, px + 80, py + 100, px + 80, py + 125); //Tooth 
            G.DrawLine(P, px + 90, py + 104, px + 90, py + 123); //Tooth 

            G.DrawString("Dylan", drawFont, drawBrush, px + 135, py + 10, drawFormat);
        }

        public void eat()
        {

        }

        public void drink()
        {

        }

        public void play()
        {

        }

        public void travel()
        {

        }

        public void feeling()
        {

        }
    }
}
