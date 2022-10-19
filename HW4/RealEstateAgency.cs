using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class RealEstateAgency
    {
        public List<Property> listofp { get; set; }

        public RealEstateAgency()
        {
            listofp = new List<Property>();
        }

        public void AddProperty(Property property)
        {
            listofp.Add(property);
        }

        public void RentProperty(string address)
        {
            foreach(Property property in listofp)
            {
                if(property.Address == address )
                {
                    RentableApartment apartment = (RentableApartment)(Apartment)property;

                    if( apartment.IsRented == true)
                    {
                        Console.WriteLine("Already rented");
                    }
                    else
                    {
                        ((RentableApartment)apartment).IsRented = true;
                        Console.WriteLine("You just rented");
                    }
                }
            }
        }

        public override string ToString()
        {
            string output = "";
            foreach(Property property in listofp)
            {
                output += property.ToString();
            }
            return output;
        }
    }
}
