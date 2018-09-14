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

        public Leo(int _x=300, int _y=400, int _width=200, int _height=100, string personName="Leo")
        {
            int x = _x;
            int y = _y;
            int width = _width;
            int height = _height;
            string PersonName = personName;
        }

        public void Draw(Graphics G)
        {
            int x = 10;
            int y = 20;
            int width = 100;
            int height = 50;

            Pen P = new Pen(Color.Black);
            SolidBrush B = new SolidBrush(Color.Black);
            Font F = new Font("Arial",14);

            Rectangle rectangle = new Rectangle(x, y, width, height);

            G.DrawString("Léo Zmoos", F, B, x, y+50);

            G.DrawEllipse(P, rectangle);
            G.DrawLine(P,rectangle.Width/2,rectangle.Height/2,3,4);
            G.DrawLine(P,rectangle.Width/2,rectangle.Height/2,15,4);
            G.DrawLine(P,rectangle.Width/2,rectangle.Height/2,30,4);
            G.DrawLine(P,rectangle.Width/2,rectangle.Height/2,45,4);
            G.DrawLine(P,rectangle.Width/2,rectangle.Height/2,60,4);
            G.DrawLine(P,rectangle.Width/2,rectangle.Height/2,75,4);
            G.DrawLine(P,rectangle.Width/2,rectangle.Height/2,90,4);
            G.DrawLine(P,rectangle.Width/2,rectangle.Height/2,120,4);
            G.DrawRectangle(P, rectangle.Width / 4, rectangle.Height-17, rectangle.Width/4,rectangle.Height/4);
            G.DrawRectangle(P, rectangle.Width-35, rectangle.Height-17, rectangle.Width/4,rectangle.Height/4);
            G.DrawArc(P,rectangle,2,3);
            
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
