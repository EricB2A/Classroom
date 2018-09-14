using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classroom
{
    class Jimmy
    {
        public int px;
        public int py;


        //Properties
        public string Firstname;
        public string Surname;
        public int Haircolor;
        public int Skincolor;
        public int Eyecolor;
        public float Weight;
        public float Height;
        public DateTime Birthday;
        private bool Gender;

        //Constructor
        public Jimmy(int x, int y)
        {
            px = x;
            py = y;
        }

        //Method
        public void Draw(Graphics G)
        {
            Image newImage = Image.FromFile("1.PNG");
            Pen P = new Pen(Color.Red);
            G.DrawImage(newImage, px, py);
        }
        public void Play() {}
        public void GoOut() {}
        public void Sleep() {}
        public void Swell() {}
        public void Slim() {}
        public void Die() {}
        public void ToGetOld() {}
        public void Shrink() {}
    }
}
