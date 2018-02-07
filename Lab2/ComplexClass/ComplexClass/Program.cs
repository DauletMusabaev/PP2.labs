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
            public static Complex operator -(Complex j, Complex k)
            {
                Complex l = new Complex((j.x * k.y - k.x * j.y) / gcd(j.y, k.y), j.y * k.y / gcd(j.y,k.y));
                l.Simple();
                return l;
            }
            public static Complex operator *(Complex j, Complex k)
            {
                Complex l = new Complex(j.x * k.x, j.y * k.y);
                l.Simple();
                return l;
            }
            public static Complex operator /(Complex j, Complex k)
            {
                Complex l = new Complex(j.x * k.y, j.y * k.x);
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
            string[] d1 = new string[2];
            string[] d2= new string[2];

            d1 = s1.Split('/');
            d2 = s2.Split('/');

            int a1 = int.Parse(d1[0]);
            int a2 = int.Parse(d1[1]);
            int b1 = int.Parse(d2[0]);
            int b2 = int.Parse(d2[1]);

            Complex q = new Complex(a1, a2);
            Complex w = new Complex(b1, b2);

            Complex e = q + w;
            Complex r = q - w;
            Complex t = q * w;
            Complex i = q / w;

            Console.WriteLine("Sum = " + e);
            Console.WriteLine("Substraction = " + r);
            Console.WriteLine("Multiplication = " + t);
            Console.WriteLine("Division = " + i);
            Console.ReadKey();
        }
    }
}
