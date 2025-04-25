using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_List_LINQ
{
    public class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }

        public Student(string name, int age, double gpa ) 
        {
            Name = name;
            Age = age;
            GPA = gpa;
        }
    }
}
