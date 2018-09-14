﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class Joao
    {
        public int px;
        public int py;

        public string LastName;
        public string Firstname;
        public string EyesColor;
        public int Height;
        public int Weight;
        public string HairColor;
        public string Gender;
        public string SkinColor;


        public Joao(int p1, int p2)
        {
            
            LastName = "Alipio Penedo";
            Firstname = "Joao Paulo";
            EyesColor = "Brun";
            Height = 180;
            Weight = 65;
            HairColor = "Brun";
            Gender = "Homme";
            SkinColor = "Blanc";
            px = p1;
            py = p2;
            
            

        }

        public void Draw(Graphics G)
        {
            Pen P = new Pen(Color.DarkOrange);
            G.DrawLine(P, px, py, px, py-15);
            G.DrawLine(P, px, py-15, px+25, py );
            G.DrawLine(P, px, py, px, py+50);
            G.DrawLine(P, px, py+50/2, px-25, py+50);
            G.DrawLine(P, px-25, py+50, px-25, py+75 );
            G.DrawLine(P, px - 25, py + 75, px + 25 , py +75);
            G.DrawLine(P, px + 25, py + 75, px +25, py );
        }
    }
}