using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Classroom
{
    class Sacha
    {
        int spx;
        int spy;

        public string Name;
        public bool Man;
        public DateTime BirthDay;
        public Byte Size;
        public Byte Weight;
        public Color EyeColor;
        public Color HairColor;
        public string Job;
        public List<string> Hobbies = new List<string>();

        public Sacha(int px, int py)
        {
            this.Name = "Sacha";
            this.Man = true;
            this.BirthDay = DateTime.Today;
            this.Size = 170;
            this.Weight = 50;
            this.EyeColor = Color.Brown;
            this.HairColor = Color.Brown;
            this.Job = "Informaticien";
            this.Hobbies = new List<string>()
            {
                "Jeux videos",
                "Films"
            };

            spx = px;
            spy = py;
        }

        public void Draw(Graphics G)
        {
            Pen Body = new Pen(Color.SkyBlue);
            G.DrawRectangle(Body, spx+ 50, spy+30, 30, 80);
            
            Pen Arms = new Pen(Color.Black);
            G.DrawRectangle(Arms, spx, spy+30, 50, 10);
            G.DrawRectangle(Arms, spx+80, spy+30, 50, 10);

            Pen Legs = new Pen(Color.Green);
            G.DrawRectangle(Legs, spx+50, spy+110, 10, 50);
            G.DrawRectangle(Legs, spx+70, spy+110, 10, 50);

            Pen Head = new Pen(Color.Red);
            G.DrawArc(Head, spx+50, spy, 30, 30, 0, 360);
        }

        public void GetJob()
        {
            
        }

        public void AddHobbie()
        {

        }

        public void RemoveHobbie()
        {

        }

    }
}
