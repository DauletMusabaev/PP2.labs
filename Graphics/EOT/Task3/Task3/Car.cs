using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Threading.Tasks;

namespace Task3
{
    class Car
    {
        public int xc, yc;
        public Pen pen = new Pen(Color.Red);
        public GraphicsPath gp;
        public Car(int x, int y)
        {
            xc = x;
            yc = y;
        }
        public void Draw(Graphics g)
        {
            gp = new GraphicsPath();
            int w = 30;
            int h = 20;
            gp.AddRectangle(new Rectangle(xc, yc, w + 35, h + 20));

            gp.AddLine(xc + 10, yc, xc + 25, yc - 30);
            gp.AddLine(xc + 25, yc - 30, xc + 25 + (w / 2), yc - 30);
            gp.AddLine(xc + 25 + (w / 2), yc - 30, xc + 25 + (w / 2) + 15, yc);
            gp.AddEllipse(xc + 10, yc + h + 15, 10, 10);
            gp.AddEllipse(xc + 25 + (w / 2) + 10, yc + h + 15, 10, 10);
            g.DrawPath(pen, gp);
        }
    }
}
