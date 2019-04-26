using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example4
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }
        Tank t = new Tank(50, 50);

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t.direction == 0)
                t.x += 2;
            if(t.direction == 1)
                t.x -= 2;
            if (t.direction == 2)
                t.y -= 2;
            if (t.direction == 3)
                t.y += 2;

            g.Clear(Color.White);
            t.Draw(g);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
                t.direction = 0;
            if (e.KeyCode == Keys.A)
                t.direction = 1;
            if (e.KeyCode == Keys.W)
                t.direction = 2;
            if (e.KeyCode == Keys.S)
                t.direction = 3;
        }
    }
}
