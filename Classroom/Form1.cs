using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Classroom
{
    public partial class Form1 : Form
    {
        Graphics G;

        Sylvain theSylvain ;
        Jimmy theJimmy;
        Dylan theDylan;
        Jeremy theJeremy;

        Leo theLeo ;
        Eqbal theEqbal;
        Benoit theBenoit;
        Ilan theIlan;

        Filipe theFilipe;
        Joao theJoao;
        Jason theJason;

        Quentin theQuentin;
        Dorian theDorian;
        Sacha theSacha;
        Cyril theCyril;

        public Form1()
        {
            InitializeComponent();

            this.Paint += new PaintEventHandler(MyPaint);
            theSylvain = new Sylvain(10, 10);
            theJimmy = new Jimmy(220, 10);
            theDylan = new Dylan(430, 10);
            theJeremy = new Jeremy(640, 10);

            theLeo = new Leo(10, 220);
            theEqbal = new Eqbal(220, 220);
            theBenoit = new Benoit(430, 220);
            theIlan = new Ilan(640, 220);
            
            theFilipe = new Filipe(10, 430);
            theJoao = new Joao(220, 430);
            theJason = new Jason(430, 430);

            theQuentin = new Quentin(10, 640);
            theDorian = new Dorian(220, 640);
            theSacha = new Sacha(430, 640);
            theCyril = new Cyril(640, 640);
        }

        private void MyPaint(object sender, PaintEventArgs e)
        {
            G = e.Graphics;
            theSylvain.Draw(G);
            theJimmy.Draw(G);
            theDylan.draw(G);
            theJeremy.Draw(G);

            theLeo.Draw(G);
            theEqbal.draw(G);
            theBenoit.Draw(G);
            theIlan.draw(G);

            theFilipe.Draw(G);
            theJoao.Draw(G);
            theJason.Draw(G);

            theQuentin.Draw(G);
            theDorian.Draw(G);
            theSacha.Draw(G);
            theCyril.Draw(G);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
            /*
            theSylvain.DoSomething();
            theJimmy.DoSomething();
            theDylan.DoSomething();
            theJeremy.DoSomething();

            theLeo.DoSomething();
            theEqbal.DoSomething();
            theBenoit.DoSomething();
            theIlan.DoSomething();

            theFilipe.DoSomething();
            theJoao.DoSomething();
            theJason.DoSomething();

            theQuentin.DoSomething();
            theDorian.DoSomething();
            theSacha.DoSomething();
            theCyril.DoSomething();
            */

            this.Refresh();
        }
    }
}
