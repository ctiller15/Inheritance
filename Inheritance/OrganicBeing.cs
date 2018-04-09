using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class OrganicBeing : Being
    {
        public void Wakeup()
        {
            this.IsAsleep = false;
            Console.WriteLine(this.IsAsleep);
        }

        public void FallAsleep()
        {
            this.IsAsleep = true;
            Console.WriteLine(this.IsAsleep);
        }
    }
}
