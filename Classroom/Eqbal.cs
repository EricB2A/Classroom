using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;

namespace Classroom

{
    class Eqbal
    {
        public string FirstName;
        public string LastName;
        public string BirthDate;
        public string Gender;
        public int Height;
        public int Weight;
        public string Nationality;
        public string PlaceBirth;
        public string HairColor;
        public string SkinColor;
        public string EyesColor;
        public string CivilState;
        public string SpokenLanguages;
        private int x;
        private int y;
      


        //constructor
      
        public Eqbal(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        
        //methods
        public void draw(Graphics G)
        {
            Pen P = new Pen(Color.SkyBlue);

            G.DrawLine(P,x, y, x, y + 40);
            G.DrawLine(P, x, y, x + 20, y + 20);
            Pen P2 = new Pen(Color.Red);

            G.DrawLine(P2, x+20, y+20, x+30, y - 20);
        }



    }
    

  
}
