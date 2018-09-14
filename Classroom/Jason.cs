using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Classroom
{

    class Jason
    {

        public string HairColor;
        public string EyesColor;
        public DateTime Birthday;
        public int HeightCM;
        public string Gender;
        public int Weight;
        public string Personnality;
        public string FavoriteSport;
        public String City;


        public void Draw(Graphics G)
        {
            Pen P = new Pen(Color.Salmon);
            G.DrawLine(P, HeightCM, 10, Weight, HeightCM);
            G.DrawLine(P, HeightCM, 10, Weight + Weight, HeightCM);
            G.DrawLine(P, HeightCM, Weight, HeightCM *2 , Weight);
        }
     
        public Jason(int px, int py)
        {
            HairColor = "";
            EyesColor = "";
            Birthday = new DateTime (2000,3,10);
            HeightCM = px;
            Gender = "M";
            Weight = py;
            Personnality = "Introvertie, Joie de vivre";
            FavoriteSport = "Football";
            City = "Vallorbe";
        }
    }
}
