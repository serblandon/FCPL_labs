using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] array = new Student[n];

            double maxgrade = 0;
            int student = 0;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Name: ");
                String name = Console.ReadLine();
                Console.WriteLine("Year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Grade1: ");
                double grade1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Grade2: ");
                double grade2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Grade3: ");
                double grade3 = Convert.ToDouble(Console.ReadLine());

                array[i] = new Student(name, year, grade1, grade2, grade3);

                Console.WriteLine(array[i].AverageGrade());
                Console.WriteLine(array[i].ToString());
                
                if(maxgrade < array[i].AverageGrade())
                {
                    maxgrade = array[i].AverageGrade();
                    student = i;
                }
            }

            Console.WriteLine("Highest Grade is: " + maxgrade + " by student " + array[student].Name);
        }
    }
}
