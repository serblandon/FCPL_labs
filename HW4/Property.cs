using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public abstract class Property
    {
        public string Address { get; set; }
        public float IndoorArea { get; set; }
        public float PropertyValue { get; set; }

        public Property(string address, float indoorarea, float propertyvalue)
        {
            Address = address;
            IndoorArea = indoorarea;
            PropertyValue = propertyvalue;
        }

        public override string ToString()
        {
            return "Address " + Address + "Indoor area " + IndoorArea + "Property value " + PropertyValue;
        }
    }
}
