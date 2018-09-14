using Classroom;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Classroom
{
    class Dorian
    {

        public string Name { get; private set; }
        public Gender Gender { get; private set; }
        public int Size { get; private set; }
        public int Weight { get; private set; }
        public Color HairColor { get; private set; }
        public Color EyesColor { get; private set; }
        public DateTime BornDate { get; private set; }
        public string Job { get; private set; }
        public List<string> Hobbies { get; private set; } = new List<string>();

        public Point Position { get; private set; }

        private Form1 form;

        public Dorian(int px, int py)
        {
            this.Name = "Dorian";
            this.Gender = Gender.Man;
            this.Size = 166;
            this.Weight = 50;
            this.HairColor = Color.Orange;
            this.EyesColor = Color.Brown;
            this.BornDate = new DateTime(2000, 5, 22);
            this.Job = "CFC Informaticien";
            this.Hobbies = new List<string>()
            {
                "Informatique",
                "Jeux vidéos"
            };

            this.Position = new Point(px, py);
            /*this.form = form1;

            this.form.KeyPreview = true;
            this.form.KeyPress += new KeyPressEventHandler(KeyDown);*/
        }

        public void Draw(Graphics G)
        {
            Pen P = new Pen(this.HairColor);
            Point[] points = new Point[] {
                new Point(50, 0),
                new Point(100, 0),
                new Point(100, 20),
            
                new Point(150, 0),
                new Point(150, 10),
                new Point(100, 30),

                new Point(100, 50),

                new Point(90, 50),
                new Point(90, 100),
                new Point(80, 100),
                new Point(80, 50),

                new Point(70, 50),
                new Point(70, 100),
                new Point(60, 100),
                new Point(60, 50),

                new Point(50, 50),

                new Point(50, 30),
                new Point(0, 10),
                new Point(0, 0),
                new Point(50, 20)
            };

            for (int i = 0; i<points.Count(); i++)
            {
                points[i].X += this.Position.X;
                points[i].Y += this.Position.Y;
            }

            G.DrawPolygon(P, points);
        }

        public void KeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'd') Move(new Point(5,0));
            if (e.KeyChar == 'a') Move(new Point(-5, 0));
            if (e.KeyChar == 'w') Move(new Point(0, -5));
            if (e.KeyChar == 's') Move(new Point(0, 5));

            Random random = new Random();
            if (e.KeyChar == ' ')
            {
                DyeHair(Color.FromArgb(255, random.Next(255), random.Next(255), random.Next(255)));
                this.form.Refresh();
            }
        }

        public void Move(Point direction)
        {
            this.Position = new Point(this.Position.X + direction.X, this.Position.Y + direction.Y);
            this.form.Refresh();
        }

        public int GetAge()
        {
            return (int)((DateTime.Now - this.BornDate).TotalDays) / 365;
        }

        public void ChangeJob(string job)
        {
            this.Job = job;
        }

        public void AddHobby(string hobby)
        {
            this.Hobbies.Add(hobby);
        }

        public void RemoveHobby(string hobby)
        {
            this.Hobbies.Remove(hobby);
        }

        public void DyeHair(Color newColor)
        {
            this.HairColor = newColor;
        }

        public void Grow(int size)
        {
            this.Size += size;
        }

    }

    public enum Gender
    {
        Man,
        Woman,
        Other
    }
}
