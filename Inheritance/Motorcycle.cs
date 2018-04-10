using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Motorcycle : AutomaticVehicle , IBike
    {
        public Motorcycle()
        {
            this.Wheels = 2;
            this.Seats = 1;
        }
    }
}
