using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class C1
    {
    public static void swap(ref int a, ref int b)
            {
                int aux = a;
                a = b;
                b = aux;
        }
    }

    public class C2
    {
        public static Coords Middle(Coords c1, Coords c2)
        {
            return new Coords
            {
                X = (c1.X + c2.X) / 2,
                Y = (c1.Y + c2.Y) / 2
            };
            //return new Coords(((c1.X + c2.X) / 2.0f), (c1.Y + c2.Y) / 2.0f);
        }
    }
    
    public struct Coords
    {
        public float X { get; set; }
        public float Y { get; set; }

        public override string ToString()
        {
            return "X:" + X + "Y: " + Y;
        }
    }


    public class Account
    {
        public string name {get; set;}
        public double balance { get; set; }

        public Account(string Name, double Balance)
        {
            name = Name;
            balance = Balance;
        }

        public bool Withdraw(double Amount, out double Remainingbalance)
        {
            if(Amount > balance)
            {
                Remainingbalance = balance;
                return false;
            }
            else
            {
                Remainingbalance = balance - Amount;
                balance -= Amount;
                return true;
            }
        }
    }

    class Program
    {

        
        static void Main(string[] args)
        {
            int a = 3;
            int b = 7;
            Class1.swap(ref a,ref b);
            Console.WriteLine("a:" + a + "b:" + b);

            Coords co1 = new Coords();
            co1.X = 2.0f;
            co1.Y = 3.0f;

            Coords co2 = new Coords();
            co2.X = 5.0f;
            co2.Y = 9.0f;

            Console.WriteLine(C2.Middle(co1,co2));

            Account acc1 = new Account("account1", 100.0f);
            double remain;
            Console.WriteLine(acc1.Withdraw(120, out remain) + "remaining" + remain);
           
        }
    }
}
