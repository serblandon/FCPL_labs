using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class RentableApartment : Apartment, IRentable
    {
        public bool IsRented { get; set; }
        public float MonthlyRent { get; set; }

        public RentableApartment(string address, float indoorarea, float propertyvalue, int floor, bool haselevator, bool isrented, float monthlyrent)
            : base(address, indoorarea, propertyvalue, floor, haselevator)
        {
            IsRented = isrented;
            MonthlyRent = monthlyrent;
        }

        public override string ToString()
        {
            return base.ToString() + "Is rented " + IsRented + "Monthly rent " + MonthlyRent;
        }
    }
}
