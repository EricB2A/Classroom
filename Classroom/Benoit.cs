using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Classroom
{
    class Benoit
    {
        //Parameters
        private string Name;
        private Color HairColor;
        private int Height;
        private int Weight;
        private string EyesColor;
        private int Age;
        private int Anniversary;
        private List<string> Clothes; //string can be replace by an "Clothe" object... just have to do it
        private bool Alive = true;
        private bool isSleeping;
        private bool IsWorking;
        private bool hungry;
        private bool Gender;

        private int x;
        private int y;
        private int width;
        private int height;




        //Methods
        public Benoit(int _x = 50, int _y = 50, int _width = 100, int _height = 100, string personName = "Benoit")
        {
            Name = personName;
            x = _x;
            y = _y;
            width = _width;
            height = _height;
            
        }

        public void Draw(Graphics G)
        {
            
            Rectangle rectangle = new Rectangle(x,y,width,height);
            Pen P = new Pen(Color.Black);
            G.DrawRectangle(P, rectangle);
            G.DrawEllipse(P, rectangle);
            G.DrawLine(P, x, y, x+width, y+height);;
            G.DrawLine(P, x+width, y, x, y+height);

            

        }

        public void ReDraw()
        {
            x += 10;
            y += 10; 
        }



      
        public string Speak(string message)
        {
            return Name + " : " + message;
        }

        public void goSleep()
        {
            if (!isSleeping)
            {
                Console.WriteLine(Name + " va se coucher à : " + DateTime.Now);
                isSleeping = true;
            }
            else
            {
                Console.WriteLine(Name + " dort déjà, chuuuut...");
            }
        }

        public void WakeUp()
        {
            if (isSleeping)
            {
                Console.WriteLine(Name + "se réveille à : " + DateTime.Now);
                isSleeping = true;
            }
            else
            {
                Console.WriteLine(Name + " est déja réveillé");
            }
           
        }

        public void Dye(Color color)
        {
            HairColor = color;
        }

        public int getX()
        {
            return x;
        }

       


    }
}
