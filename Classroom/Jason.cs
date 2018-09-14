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
        int i = 0;
        public string HairColor;
        public string EyesColor;
        public DateTime Birthday;
        public int HeightCM;
        public string Gender;
        public int Weight;
        public string Personnality;
        public string FavoriteSport;
        public String City;
        private int PosX;
        private int PosY;


        public void Draw(Graphics G)
        {
            Pen P = new Pen(Color.Salmon);
            G.DrawLine(P, PosX, PosY, Weight, HeightCM);
            G.DrawLine(P, PosX, PosY, Weight + Weight, HeightCM);
            G.DrawLine(P, Weight, HeightCM , Weight * 2, HeightCM);


        }
     
        public Jason(int px, int py)
        {
            HairColor = "";
            EyesColor = "";
            Birthday = new DateTime (2000,3,10);
            HeightCM = 174;
            Gender = "M";
            Weight = 69;
            Personnality = "Introvertie, Joie de vivre";
            FavoriteSport = "Football";
            City = "Vallorbe";
            PosX = px;
            PosY = py;
            
        }

        public void DoSomething()
        {
            i++;
            switch (i)
            {
                  
                case 1:

                System.Windows.Forms.MessageBox.Show("La Kpop c'est bien...");
                  
                    break;
                case 2:
                    System.Windows.Forms.MessageBox.Show("C'est pas des chinois bordel...");
                    break;
                case 3:
                    System.Windows.Forms.MessageBox.Show("Don't rage my friend... Kpop is bae");
                    break;
                default :
                    System.Windows.Forms.MessageBox.Show("Je pense que la Kpop devrait être plus commercialisée dans le monde");
                    
                    break;
            }   
            
            

        }
    }
}
