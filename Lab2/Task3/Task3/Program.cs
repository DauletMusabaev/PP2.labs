using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        static void mps(int[] r)
        { 
            for (int i = 0; i < r.Length; i++)
            {
                if (r[i] == 1) r[i] = 0;
                for (int j = 2; j <= Math.Sqrt(r[i]); ++j)
                {
                    if (r[i] % j == 0)
                    {
                        r[i] = 0;
                    }
                }
               
            }


        }
        static void Main(string[] args)
        {
            string rp = @"C:\work\PP2\Lab2\Task3\in.txt";
            string wp = @"C:\work\PP2\Lab2\Task3\out.txt";

            string text = "";

            try
            {
                using (StreamReader sr = new StreamReader(rp, System.Text.Encoding.Default))
                {
                    text = sr.ReadToEnd();
                }

                string[] arr = text.Split();
                int[] a = new int[123456];
                int mini = 1234567;

                for (int i = 0; i < arr.Length; i++)
                    a[i] += int.Parse(arr[i]);
                mps(a);
                using (StreamWriter sw = new StreamWriter(wp, false, System.Text.Encoding.Default))
                {

                    for (int i = 0; i < a.Length; i++)
                        if (a[i] != 0)
                            mini = Math.Min(a[i], mini);

                    sw.WriteLine(mini);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
