using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            RealEstateAgency realestateagency = new RealEstateAgency();

            RentableApartment rentableapartment = new RentableApartment("str avc", 50, 1000, 2, true, false, 200);

            realestateagency.AddProperty(rentableapartment);
            
            Console.WriteLine(rentableapartment);

            realestateagency.RentProperty("str avc");

            Console.WriteLine(realestateagency);

            realestateagency.RentProperty("str avc");

            Console.ReadKey();
        }
    }
}
