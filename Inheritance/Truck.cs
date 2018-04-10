using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Truck : AutomaticVehicle
    {
        public Truck()
        {
            this.Wheels = 4;
            this.Seats = 2;
        }
    }
}
