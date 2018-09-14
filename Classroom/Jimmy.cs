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
        public bool GoodHumor;

        //Constructor
        public Jimmy(int x, int y)
        {
            px = x;
            py = y;
            GoodHumor = true;
        }

        //Method
        public void Draw(Graphics G)
        {
            String drawString = "Jimmy Catarino";
            Font drawFont = new Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            Image newImage = Image.FromFile("jimmy.PNG");
            Pen P = new Pen(Color.Red);
            G.DrawImage(newImage, px, py);
            if(GoodHumor == true)
            {
                G.DrawString(drawString, drawFont, drawBrush, px, py+70);
            }

        }

        public void DoSomething()
        {
            //System.Windows.Forms.MessageBox.Show("Pour Quentin ^^ : \r \rJe m'présente, je m'appelle Henri J'voudrais bien réussir ma vie, être aimé Etre beau gagner de l'argent Puis surtout être intelligent Mais pour tout ça il faudrait que j'bosse à plein temps J'suis chanteur, je chante pour mes copains ");
            if(GoodHumor == false)
            {
                GoodHumor = true;
            }
            else
            {
                GoodHumor = false;
            }
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
