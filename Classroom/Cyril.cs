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
        public int px;
        public int py;

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

        public Cyril()
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
        }


        public void Draw(Graphics G)
        {
            Pen P = new Pen(Color.Black);
            Pen pen = new Pen(Color.White);
            // Corps
            G.DrawLine(P, px+200, py+150, px+200, py+300);
            //Pied droite
            G.DrawLine(P, px+200, py+300, px+150, py+380);
            //Pied gauche
            G.DrawLine(P, px+200, py+300, px+250, py+380);
            //Tête
            G.DrawEllipse(P, px + 165, py + 80, px - 30, py + 20);
            //Bouche
            Rectangle rect = new Rectangle(px + 175, py + 90, px - 50, py);
            float startAngle = 35.0F;
            float sweepAngle = 100.0F;
            G.DrawArc(P, rect, startAngle, sweepAngle);
            //Yeux
            G.DrawEllipse(P, px + 180, py + 100, px - 90, py - 40);
            G.DrawEllipse(P, px + 210, py + 100, px - 90, py - 40);
            SolidBrush brush = new SolidBrush(EyeColor);

            G.FillEllipse(brush, px + 180, py + 100, px - 90, py - 40);
            G.FillEllipse(brush, px + 210, py + 100, px - 90, py - 40);
            int pz = py + 150;
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
                G.DrawLine(P, px + 200, py + 200, px + 150, pz);
                //Bras droite
                //G.DrawLine(pen, px + 200, py + 200, px + 150, pw + i);
                //Bras gauche
                G.DrawLine(P, px + 200, py + 200, px + 250, pz);
                
                //Bras gauche
                //G.DrawLine(pen, px + 200, py + 200, px + 250, pw + i);
               /* Thread.Sleep(5);
            }*/

            



        }

        public void GetJob()
        {
           
        }

        public void AddHobby()
        {

        }

        public void RemoveHobby()
        {

        }

    }


}
