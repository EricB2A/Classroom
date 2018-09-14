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
            Spx = px;
            Spy = py;
            
    }
        public void Draw(Graphics G)
        {
            Pen P = new Pen(Color.Black);
            Pen pen = new Pen(Color.White);
            // Corps
            G.DrawLine(P, Spx + 100, Spy + 40, Spx + 100, Spy + 120);
            //Pied droite
            G.DrawLine(P, Spx + 100, Spy + 120, Spx + 80, Spy + 140);
            //Pied gauche
            G.DrawLine(P, Spx + 100, Spy + 120, Spx + 120, Spy + 140);
            //Tête
            G.DrawEllipse(P, Spx + 85, Spy + 10, 30, 30);
            /*//Bouche
            Rectangle rect = new Rectangle(Spx + 175, Spy + 90, Spx - 50, Spy);
            float startAngle = 35.0F;
            float sweepAngle = 100.0F;
            G.DrawArc(P, rect, startAngle, sweepAngle);*/
            //Yeux
            G.DrawEllipse(P, Spx + 90, Spy + 20, 5, 5);
            G.DrawEllipse(P, Spx + 105, Spy + 20, 5, 5);
            SolidBrush brush = new SolidBrush(EyeColor);

            G.FillEllipse(brush, Spx + 90, Spy + 20, 5, 5);
            G.FillEllipse(brush, Spx + 105, Spy + 20, 5, 5);

            //Bras droite
            G.DrawLine(P, Spx + 100, Spy + 50, Spx + 80, Spy + 30);
            //Bras gauche
            G.DrawLine(P, Spx + 100, Spy + 50, Spx + 120, Spy + 30);







        }
    }
}