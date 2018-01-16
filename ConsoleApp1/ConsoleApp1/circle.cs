using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class circle
    {
        public double radius;
        public double area;
 
        public circle()
        {
            radius = 10;
        }

        public circle(double radius)
        {
            this.radius = radius;
            findarea();
        }
        public void findarea()
        {
            area = Math.PI * radius * radius;

        }

        public override string ToString()
        {
            return "radius = " + radius + "\narea = " + area;
        }

    }
}
