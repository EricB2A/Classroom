using System;
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
        private int Click = 0;
        public string TextToWrite;
        

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
            TextToWrite = LastName;
            

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

            // Create string to draw.
            String drawString = TextToWrite;

            // Create font and brush.
            Font drawFont = new Font("Arial", 11);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            float x = px + 130;
            float y = py + 60;

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            // Draw string to screen.
            G.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
        }

        public void DoSomething()
        {

            Click++;
            
            // Create string to draw.
            switch (Click)
            {
                case 1:
                    TextToWrite = "! Stop touching Me";
                    break;

                case 2:
                    TextToWrite = "! I said STOP";
                    break;

                case 3:
                    TextToWrite = "Pq**zàrd";
                    break;

                case 4:
                    TextToWrite = "Ok, i'm feeling pretty bad right now.";
                    break;

                case 5:
                    TextToWrite = "You abused of my pixels";
                    break;


                default:
                    TextToWrite = "Ok. Bye.";
                    px -= 20;
                    break;
            }
               
           
            
        }
    }
}
