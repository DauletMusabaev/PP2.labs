using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        Graphics g;
        public static int x = 50, y = 50;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }
        Car c = new Car(x, y);

        private void timer1_Tick(object sender, EventArgs e)
        {
            c.xc += 10;
            g.Clear(Color.White);
            c.Draw(g);
        }
    }
}
