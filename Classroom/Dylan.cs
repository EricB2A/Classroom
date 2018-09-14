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

            G.DrawEllipse(P, px, py, px, py + 100); //Head
            G.DrawEllipse(P, px + 30, py + 50, px / 4, py / 4); //Left eye                  
            G.DrawEllipse(P, px + 43, py + 50, px / 4 - 25, py / 4); //Left eye
            G.DrawEllipse(P, px + 120, py + 50, px / 4, py / 4); //Right eye  
            G.DrawEllipse(P, px + 133, py + 50, px / 4 - 25, py / 4); //Right eye
            G.DrawEllipse(P, px + 75, py + 140, px / 4, py / 4); //Mouth   
            G.DrawLine(P, px + 75, py + 153, px + 125, py + 153); //Tooth 
            G.DrawLine(P, px + 85, py + 142, px + 85, py + 161); //Tooth 
            G.DrawLine(P, px + 115, py + 142, px + 115, py + 161); //Tooth 
            G.DrawLine(P, px + 100, py + 140, px + 100, py + 165); //Tooth 
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
