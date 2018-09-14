using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Classroom
{
    class Leo
    {
        public string FirstName;
        public string SurName;
        public Color HairColor;
        public Color SkinColor;
        public int Height;
        public int Weight;
        public Color EyeColor;
        public string Nationality;
        public DateTime Birthday;
        public string Gender;
        public bool Alive;
        public int px;
        public int py;

        public Leo(int rX, int rY, string personName="Leo")
        {
            px = rX;
            py = rY;
            string PersonName = personName;
        }

        public void Draw(Graphics G)
        {
            int width = 200;
            int height = 200;

            Pen P = new Pen(Color.Black);
            SolidBrush B = new SolidBrush(Color.Black);
            Font F = new Font("Arial",14);

            Rectangle rectangle = new Rectangle(px, py, width, height);

            G.DrawString("Léo Zmoos", F, B, px+50, py+210);

            G.DrawEllipse(P, rectangle);
            G.DrawEllipse(P, px+32,py+60,52,60);
            G.DrawEllipse(P, px+100,py+60,52,60);
            G.DrawEllipse(P, px+114,py+60,26,60);
            G.DrawEllipse(P, px+46,py+60,26,60);
            G.DrawEllipse(P, px+80,py+150,26,30);
            
        }

        public void Walk() { }

        public void Speak() { }

        public void Eat() { }

        public void Die() { }

        public void Drive() { }

        public void toSwell() { }

        public void toSleep() { }

        public void toSlim() { }

        public void toGrow() { }

        public void toGetOld() { }

        public void toShrink() { }


    }
}
