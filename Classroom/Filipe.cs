using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class Filipe
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime Birth { get; private set; }
        public string Gender { get; private set; }
        public string HairColor { get; private set; }
        public string EyesColor { get; private set; }
        public string SkinColor { get; private set; }
        public int Heigth { get; private set; }
        public float Weigth { get; private set; }

        public Filipe()
        {

        }

        public void Draw(Graphics G)
        {
            Pen P = new Pen(Color.DarkRed);
            //G.DrawPolygon(P);
        }

    }
}
