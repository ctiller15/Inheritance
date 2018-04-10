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

            //var Existence = new Being();
            //Console.WriteLine(Existence.Birthday);
            //Console.WriteLine(Existence.Name);
            //Console.ReadLine();

            var creator = new Creation();
            List<Being> Life = new List<Being>();

            //var Chris = new Human("Chris");
            //var Bubba = new Panda("Bubba");
            //var Darrell = new Robot("Darrell");

            //Life.Add(Chris);
            //Life.Add(Bubba);
            //Life.Add(Darrell);

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

            //Chris.Adopt(Bubba);
            //Chris.Adopt(Darrell);
            //Console.WriteLine(Chris.ToString());
            //Console.WriteLine(Bubba.ToString());
            //Console.WriteLine(Darrell.ToString());
            bool created = false;
            Human person;
            while (!created)
            {
                // prompt the user for their human name.
                string HumanName = creator.CreationPrompt();
                if(HumanName != "")
                {
                    person = new Human(HumanName);
                    Console.WriteLine(person.ToString());
                    created = true;

                    bool isRunning = true;
                    while (isRunning)
                    {
                        Adoption.ManageAdoption(person);
                    }
                }
            }


            Console.ReadLine();
        }
    }
}
