using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;

namespace Classroom
{
    class Cyril
    {
        public int Spx;
        public int Spy;
        public int SpyF;
        public int SpxF;

        public string Name;
        public Color SkinColor;
        public Color HairColor;
        public Color EyeColor;
        private string Job;
        public int Age;
        public string Size;
        public string Weight;
        public DateTime Birthday;
        public bool Man;
        public List<string> Hobby;

        public Cyril(int px, int py)
        {
            this.Name = "Cyril";
            this.SkinColor = Color.White;
            this.HairColor = Color.Brown;
            this.EyeColor = Color.SkyBlue;
            this.Job = "Informaticien";
            this.Age = 18;
            this.Size = "1,80";
            this.Weight = "110,4";
            this.Birthday = DateTime.Now;
            this.Man = true;
            this.Hobby = new List<string>()
            {
                "Jeux videos",
                "Lecture"
            };
            Spy = py + 50;
            Spx = px + 100;
            SpxF = 100 + px;
            SpyF = 50 +py;
        }


        public void Draw(Graphics G)
        {
            Pen P = new Pen(Color.Black);
            Pen pen = new Pen(Color.White);
            // Corps
            G.DrawLine(P, Spx + 200, Spy + 150, SpxF + 200, SpyF + 300);
            //Pied droite
            G.DrawLine(P, Spx + 200, Spy + 300, SpxF + 150, SpyF + 380);
            //Pied gauche
            G.DrawLine(P, Spx + 200, Spy + 300, SpxF + 250, SpyF + 380);
            //Tête
            G.DrawEllipse(P, Spx + 165, Spy + 80, SpxF - 40, SpyF + 10);
            /*//Bouche
            Rectangle rect = new Rectangle(Spx + 175, Spy + 90, Spx - 50, Spy);
            float startAngle = 35.0F;
            float sweepAngle = 100.0F;
            G.DrawArc(P, rect, startAngle, sweepAngle);*/
            //Yeux
            G.DrawEllipse(P, Spx + 180, Spy + 100, SpxF - 100, SpyF - 50);
            G.DrawEllipse(P, Spx + 210, Spy + 100, SpxF - 100, SpyF - 50);
            SolidBrush brush = new SolidBrush(EyeColor);

            G.FillEllipse(brush, Spx + 180, Spy + 100, SpxF - 100, SpyF - 50);
            G.FillEllipse(brush, Spx + 210, Spy + 100, SpxF - 100, SpyF - 50);
            int pz = Spy + 150;
            /*int pw = py + 148;
            int i = 0;
            int x = 0;
            bool Vrai = true;
            while (Vrai)
            {
                if(x == 0)
                {
                    i++;
                    if(i >= 100)
                    {
                        x = 1;
                    }
                }
                if(x == 1)
                {
                    i--;
                    if(i == 0)
                    {
                        x = 0;
                        //Vrai = false;
                    }
                }
                */
                //Bras droite
                G.DrawLine(P, Spx + 200, Spy + 200, SpxF + 150, pz);
                //Bras droite
                //G.DrawLine(pen, px + 200, py + 200, px + 150, pw + i);
                //Bras gauche
                G.DrawLine(P, Spx + 200, Spy + 200, SpxF + 250, pz);
                
                //Bras gauche
                //G.DrawLine(pen, px + 200, py + 200, px + 250, pw + i);
               /* Thread.Sleep(5);
            }*/

            



        }
    }


}
