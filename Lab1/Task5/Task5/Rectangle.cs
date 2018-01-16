using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Rectangle
    {
        public double width;
        public double length;
        public double area;
        
        public Rectangle()
        {
            width = 10;
            length = 15;
            findArea();
        }

        public void findArea()
        {
            area = length * width;
        }

        public override string ToString()
        {
            return "area = " + area;
        }
    }
}
