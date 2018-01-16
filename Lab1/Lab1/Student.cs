using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Student
    {
        public string name;
        public double gpa;
        public int age;
           
        public Student()
        {
            name = "Daulet";
            age = 18;
            gpa = 4.0;
        }

        public override string ToString()
        {
            return name + " " + age + " " + gpa ;
        }
    }

}
