using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split(' '); 
            foreach (string s in arr)
            {
                int x = int.Parse(s); 
                bool ok = true;
                for (int i = 2; i * i <= x; i++)
                {
                    if (x % i == 0)
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok & x != 1) 
                {
                    Console.WriteLine(x); 
                }
                ok = true;
            }
            Console.ReadKey(); 
        }
    }
}
