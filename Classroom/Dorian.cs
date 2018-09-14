using Classroom;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private PointF[] forme = new PointF[] {
                new PointF(50, 0),
                new PointF(100, 0),
                new PointF(100, 20),

                new PointF(150, 0),
                new PointF(150, 10),
                new PointF(100, 30),

                new PointF(100, 50),

                new PointF(90, 50),
                new PointF(90, 100),
                new PointF(80, 100),
                new PointF(80, 50),

                new PointF(70, 50),
                new PointF(70, 100),
                new PointF(60, 100),
                new PointF(60, 50),

                new PointF(50, 50),

                new PointF(50, 30),
                new PointF(0, 10),
                new PointF(0, 0),
                new PointF(50, 20)
            };

        private bool HandsUp = false;

        public Dorian(int px, int py)
        {
            this.Name = "Dorian";
            this.Gender = Gender.Man;
            this.Size = 166;
            this.Weight = 50;
            this.HairColor = Color.Orange;
            this.EyesColor = Color.Brown;
            this.BornDate = new DateTime(2000, 5, 22);
            this.Job = "Informaticien";
            this.Hobbies = new List<string>()
            {
                "Informatique",
                "Jeux vidéos",
                "Programmation"
            };

            this.Position = new Point(px, py);
        }

        public void Draw(Graphics G)
        {
            Pen pen = new Pen(this.HairColor, 6);
            Brush brush = new SolidBrush(this.EyesColor);

            PointF[] formToDraw = new PointF[forme.Count()];

            for (int i = 0; i < formToDraw.Count(); i++)
            {
                formToDraw[i].X = forme[i].X + this.Position.X;
                formToDraw[i].Y = forme[i].Y + this.Position.Y;
            }

            G.DrawPolygon(pen, formToDraw);
            G.FillPolygon(brush, formToDraw);
        }

        public void DoSomething()
        {
            Random random = new Random();
            DyeHair(Color.FromArgb(255, random.Next(255), random.Next(255), random.Next(255)));

            this.EyesColor = Color.FromArgb(255, random.Next(255), random.Next(255), random.Next(255));
            this.Position = new Point(Cursor.Position.X - Form1.ActiveForm.Location.X - 80, Cursor.Position.Y - Form1.ActiveForm.Location.Y - 55);

            HandsUp = !HandsUp;

            if (HandsUp)
            {
                this.forme[3] = new PointF(150, 30);
                this.forme[4] = new PointF(150, 40);

                this.forme[18] = new PointF(0, 30);
                this.forme[17] = new PointF(0, 40);
            }
            else
            {
                this.forme[3] = new PointF(150, 0);
                this.forme[4] = new PointF(150, 10);

                this.forme[18] = new PointF(0, 0);
                this.forme[17] = new PointF(0, 10);
            }
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
