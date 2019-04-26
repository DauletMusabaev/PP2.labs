using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Asteroid
{
    public partial class Form1 : Form
    {
        Graphics g;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.Blue;        
            g.DrawRectangle(new Pen(Color.Black, 10), 5, 5, 500, 400);
            //Asteroids
            SolidBrush brush = new SolidBrush(Color.Red);
            Point[] points1 = { new Point(50, 108), new Point(100, 108), new Point(75, 153) };
            g.FillPolygon(brush, points1);
            Point[] points2 = { new Point(50, 137), new Point(100, 137), new Point(75, 92) };
            g.FillPolygon(brush, points2);

            Point[] points3 = { new Point(400, 105), new Point(450, 105), new Point(425, 150) };
            g.FillPolygon(brush, points3);
            Point[] points4 = { new Point(400, 134), new Point(450, 134), new Point(425, 89) };
            g.FillPolygon(brush, points4);

            Point[] points5 = { new Point(100, 228), new Point(150, 228), new Point(125, 273) };
            g.FillPolygon(brush, points5);
            Point[] points6 = { new Point(100, 257), new Point(150, 257), new Point(125, 212) };
            g.FillPolygon(brush, points6);

            Point[] points7 = { new Point(300, 278), new Point(350, 278), new Point(325, 323) };
            g.FillPolygon(brush, points7);
            Point[] points8 = { new Point(300, 307), new Point(350, 307), new Point(325, 262) };
            g.FillPolygon(brush, points8);

            //ellipses
            SolidBrush brush1 = new SolidBrush(Color.White);
            g.FillEllipse(brush1, 30, 40, 20, 20);
            g.FillEllipse(brush1, 30, 340, 20, 20);

            g.FillEllipse(brush1, 240, 30, 20, 20);
            g.FillEllipse(brush1, 240, 320, 20, 20);

            g.FillEllipse(brush1, 330, 70, 20, 20);
            g.FillEllipse(brush1, 400, 230, 20, 20);

            g.FillEllipse(brush1, 450, 150, 20, 20);
            g.FillEllipse(brush1, 450, 350, 20, 20);


            //rocket
            SolidBrush brush2 = new SolidBrush(Color.Yellow);
            g.FillRectangle(brush2, 220, 180, 80, 30);
            //upper left -- right -- up
            Point[] points10 = { new Point(220, 180), new Point(300, 180), new Point(260, 165) };
            g.FillPolygon(brush2, points10);
            //down left -- right -- down
            Point[] points9 = { new Point(220, 210), new Point(300, 210), new Point(260, 225) };
            g.FillPolygon(brush2, points9);

            //Gun
            g.DrawLine(new Pen(Color.Green, 8), 275, 150, 260, 170);

            //Bullet
            g.DrawLine(new Pen(Color.Green, 6), 290, 125, 290, 145);
            g.DrawLine(new Pen(Color.Green, 6), 278, 135, 302, 135);
        }

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}
