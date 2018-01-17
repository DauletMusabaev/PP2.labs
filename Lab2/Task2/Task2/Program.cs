using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {

        static void Main(string[] args)
        {

            string readPath = @"C:\work\PP2\Lab2\Task2\in.txt";
            string writePath = @"C:\work\PP2\Lab2\Task2\out.txt";
            int mini = 123456;
            int maxi = -123456;

            string text = "";

            try
            {

                using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
                {
                    text = sr.ReadToEnd();
                }
                
                string[] arr = text.Split();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (int.Parse(arr[i]) < mini)
                    {
                        mini = int.Parse(arr[i]);
                    }

                    if (int.Parse(arr[i]) > maxi)
                    {
                        maxi = int.Parse(arr[i]);
                    }
                }
                
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                { 
                    sw.WriteLine(maxi);
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
