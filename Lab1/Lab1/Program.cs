using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

        
           string s = Console.ReadLine();

           int a = int.Parse(s);

           Console.WriteLine(a + 5);

         
            Console.WriteLine(n1 + n2);
            */
            Student s = new Student();
            s.name = "Adilet";
            s.surname = "Myrzakulov";
            s.gpa = 4.0;

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
