using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Creation
    {
        public Human CreateHuman(string name)
        {
            return new Human(name);
        }

        public string CreationPrompt()
        {
            Console.WriteLine("What is the name of your human?");
            string name = Console.ReadLine();
            return name;
        }
    }
}
