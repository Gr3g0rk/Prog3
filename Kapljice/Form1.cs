using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kapljice
{
    public partial class Form1 : Form
    {
        Random VreckaNakljucnihStevil = new Random();
        private List<Kapljica> kapljice = new List<Kapljica>();
        // private int[] ints= new int[];    


        public Form1()
        {
            InitializeComponent();

        }

        private void narisi(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            foreach(Kapljica kapljica in kapljice)
            {
                g.FillEllipse(Brushes.Blue, kapljica.X, kapljica.Y,5,5);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x1 = VreckaNakljucnihStevil.Next(platno.Width);
            Kapljica kapljica1 = new Kapljica(x1,0,false);
            kapljice.Add(kapljica1);

            foreach (Kapljica kapl in kapljice)
            {
                kapl.Y += 1;
            }

            platno.Refresh();


        }

        private void nalozi(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
