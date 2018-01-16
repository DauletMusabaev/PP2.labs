using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Student
    {
        public string name, surname;
        public double gpa;
           
        public Student()
        {
            name = "Daulet";
            surname = "Musabaev";
            gpa = 4.0;
        }

        public override string ToString()
        {
            return name + " " + surname + " " + gpa ;
        }
    }

}
