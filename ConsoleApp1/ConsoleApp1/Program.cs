using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {

            double r = double.Parse(Console.ReadLine());

            circle c = new circle(r);
           // c.findarea();

            Console.WriteLine(c);

            Console.ReadKey();

        }
    }
}
