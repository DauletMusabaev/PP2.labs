using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Example5
{
    class Shape
    {
        float x, y, w, h;
        Pen pen;
        public Shape(float x, float y, float w, float h, Color color)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            pen = new Pen(color, 5);
        }
        public void Draw(Graphics g)
        {
            PointF p1 = new PointF(x + w / 2, y);
            PointF p2 = new PointF(x + w / 2, y + h);
            PointF p3 = new PointF(x, y + h / 2);
            PointF p4 = new PointF(x + w, y + h / 2);
            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p3, p4);

            //draw inner circle
            float r1 = w / 4;
            float xr1 = w / 4 + x;
            float yr1 = h / 4 + y;
            g.DrawEllipse(pen, xr1, yr1, w / 2, h / 2);

            //draw outer circle
            g.DrawEllipse(pen, x, y, w, h);

        }
    }
}
