using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    class Program
    {
        class Complex
        {
            public int x, y;
            public Complex() { }

            public Complex(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public static int gcd(int a, int b)
            {
                if (b == 0) return a;
                else return gcd(b, a % b);
            }
            public void Simple()
            {
                int z = gcd(x, y);
                x = x / z;
                y = y / z;
                
            }
            public static Complex operator +(Complex j, Complex k)
            {
                Complex l = new Complex((j.x * k.y + k.x * j.y) / gcd(j.y, k.y), j.y * k.y / gcd(j.y, k.y));
                l.Simple();
                return l;
            }
            public override string ToString()
            {
                return x + "/" + y;
            }

        }
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string[] s11 = new string[2];
            string[] s22 = new string[2];
            s11 = s1.Split('/');
            s22 = s2.Split('/');
            int a1 = int.Parse(s11[0]);
            int a2 = int.Parse(s11[1]);
            int b1 = int.Parse(s22[0]);
            int b2 = int.Parse(s22[1]);
            Complex q = new Complex(a1, a2);
            Complex w = new Complex(b1, b2);
            Complex e = q + w;
            /*
            Complex r = q - w;
            Complex t = q * w;
            Complex i = q / w;
            */
            Console.WriteLine(e);
            Console.ReadKey();
        }
    }
}
