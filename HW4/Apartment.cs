using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Apartment : Property
    {
        public int Floor { get; set; }
        public bool HasElevator { get; set; }

        public Apartment(string address, float indoorarea, float propertyvalue, int floor, bool haselevator) : base(address, indoorarea, propertyvalue)
        {
            Floor = floor;
            HasElevator = haselevator;
        }

        public override string ToString()
        {
            return base.ToString() + "Floor " + Floor + "Has elevator " + HasElevator;
        }
    }
}
