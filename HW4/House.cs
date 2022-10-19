using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class House : Property
    {
        public float OutdoorArea { get; set; }
        public float TotalArea { get; set; }

        public House(string address, float indoorarea, float propertyvalue, float outdoorarea, float totalarea)
            : base(address, indoorarea, propertyvalue)
        {
            OutdoorArea = outdoorarea;
            TotalArea = indoorarea + outdoorarea;
        }

        public override string ToString()
        {
            return base.ToString() + "Outdoor area " + OutdoorArea + "Total area " + TotalArea;
        }
    }
}
