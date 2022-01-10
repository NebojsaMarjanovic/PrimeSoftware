using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Appliances:Product
    {
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public double Weight { get; set; }       

    }
}
