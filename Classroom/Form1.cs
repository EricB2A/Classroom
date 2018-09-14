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

        Sylvain theSylvain = new Sylvain(10, 10);
        Jimmy theJimmy = new Jimmy(50, 10);
        Dylan theDylan = new Dylan(90, 10);

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(MyPaint);
        }

        private void MyPaint(object sender, PaintEventArgs e)
        {
            G = e.Graphics;
            theSylvain.Draw(G);
            theJimmy.Draw(G);
            theDylan.Draw(G);
        }

        private void cmdDessiner_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            this.Refresh();
            Cursor = Cursors.Arrow;
        }

    }
}
