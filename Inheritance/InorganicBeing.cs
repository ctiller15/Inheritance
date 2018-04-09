using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class InorganicBeing : Being
    {
        public void StartUp()
        {
            this.IsAsleep = false;
            Console.WriteLine(this.IsAsleep);
        }

        public void ShutDown()
        {
            this.IsAsleep = true;
            Console.WriteLine(this.IsAsleep);
        }
    }
}
