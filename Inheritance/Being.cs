using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Being
    {
        public string Name { get; set; } = "name";
        public DateTime Birthday { get; set; } = new DateTime(1993, 5, 23);
        protected bool IsAsleep;


    }
}
