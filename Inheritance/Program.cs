using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var Existence = new Being();
            Console.WriteLine(Existence.Birthday);
            Console.WriteLine(Existence.Name);
            Console.ReadLine();

            var Chris = new Human();
            var Bubba = new Panda();
            var Darrell = new Robot();

            Chris.Wakeup();
            Chris.FallAsleep();
            Console.ReadLine();

            Bubba.Wakeup();
            Bubba.FallAsleep();
            Console.ReadLine();

            Darrell.StartUp();
            Darrell.ShutDown();
            Console.ReadLine();
        }
    }
}
