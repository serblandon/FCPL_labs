using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_prob3
{   

    public class Student
    {
        public string Name { get; }
        public int Year { get; }
        public double Grade1 { get; }
        public double Grade2 { get; }
        public double Grade3 { get; }

        public Student(string Name, int Year, double Grade1, double Grade2, double Grade3)
        {
            this.Name = Name;
            this.Year = Year;
            this.Grade1 = Grade1;
            this.Grade2 = Grade2;
            this.Grade3 = Grade3;
        }

        public double AverageGrade()
        {
            return (this.Grade1 + this.Grade2 + this.Grade3) / 3.0;
        }

        public string ToString()
        {
             return "Name " + this.Name + " Year " + this.Year + " Grade1 " + this.Grade1 + " Grade2" + this.Grade2 + " Grade3 " + this.Grade3;
        }
    }
}
