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

            var Chris = new Human("Chris");
            var Bubba = new Panda("Bubba");
            var Darrell = new Robot("Darrell");

            //Chris.SayHello();
            //Chris.Wakeup();
            //Chris.FallAsleep();
            //Console.ReadLine();

            //Bubba.SayHello();
            //Bubba.Wakeup();
            //Bubba.FallAsleep();
            //Console.ReadLine();

            //Darrell.SayHello();
            //Darrell.StartUp();
            //Darrell.ShutDown();
            //Console.ReadLine();

            //Chris.Eat("BBQ");
            //Bubba.Eat("The flesh of humans");
            Chris.Adopt(Bubba);
            Chris.Adopt(Darrell);
            Console.ReadLine();
        }
    }
}
