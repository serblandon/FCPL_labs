using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Number of variables to add: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in the variables: ");

            int sum = 0;

            for(int i =0; i < n; i++)
            {
                Console.WriteLine("Variable " + Convert.ToString(i) + "= ");
                int x = Convert.ToInt32(Console.ReadLine());
                sum += x;
            }

            Console.WriteLine("The sum is: " + Convert.ToString(sum));
            

        }
    }
}
