using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given the equation ax^2 + bx + c = 0, Give inputs for a, b, c to get solutions.");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            double delta = Math.Pow(b, 2) - (4 * a * c);

            if(delta < 0)
            {
                Console.WriteLine("No real roots.");
            }
            else if(delta == 0)
            {
                double sol = -b / (2.0 * a);
                Console.WriteLine("Sol1 = Sol2= " + Convert.ToString(sol));
            }
            else
            {
                double sol1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double sol2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Sol1= " + Convert.ToString(sol1));
                Console.WriteLine("Sol2= " + Convert.ToString(sol2));
            }
            

        }
    }
}
