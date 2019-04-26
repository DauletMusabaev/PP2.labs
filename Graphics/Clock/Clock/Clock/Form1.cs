using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        int r, rs, rm, rh, r1, r2;
        int gs, gm, gh;

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(Color.Black), xc - r, yc - r, 2 * r, 2 * r);

            int xs = xc + (int)(rs * Math.Cos(gs * Math.PI / 180));
            int ys = yc + (int)(rs * Math.Sin(gs * Math.PI / 180));

            int xm = xc + (int)(rm * Math.Cos(gm * Math.PI / 180));
            int ym = yc + (int)(rm * Math.Sin(gm * Math.PI / 180));

            int xh = xc + (int)(rh * Math.Cos(gh * Math.PI / 180));
            int yh = yc + (int)(rh * Math.Sin(gh * Math.PI / 180));

            for (int i = 0; i <= 360; i += 6)
            {
                int x1 = xc + (int)(r1 * Math.Cos(i * Math.PI / 180));
                int y1 = yc + (int)(r1 * Math.Sin(i * Math.PI / 180));
                int x2 = xc + (int)(r2 * Math.Cos(i * Math.PI / 180));
                int y2 = yc + (int)(r2 * Math.Sin(i * Math.PI / 180));
                e.Graphics.DrawLine(new Pen(Color.Purple, 2), x1, y1, x2, y2);
            }

            e.Graphics.DrawLine(new Pen(Color.Red, 3), xc, yc, xs, ys);
            e.Graphics.DrawLine(new Pen(Color.Blue, 3), xc, yc, xm, ym);
            e.Graphics.DrawLine(new Pen(Color.Yellow, 3), xc, yc, xh, yh);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            gs += 6;
            if (gs == 270)
                gm += 6;
            if (gs == 360)
                gs = 0;
            label1.Text = gs.ToString() + " " + gm.ToString();
            Refresh();
        }

        int xc, yc;

        public Form1()
        {
            InitializeComponent();
            r1 = 72;
            r2 = 78;
            r = 80;
            rs = 70;
            rm = 60;
            rh = 50;
            DateTime date = DateTime.Now;
            gs = date.Second * 6 - 90;
            gm = date.Minute * 6 - 90;
            gh = date.Hour * 30 - 90;

            xc = Width / 2;
            yc = Height / 2;

        }

    }
}