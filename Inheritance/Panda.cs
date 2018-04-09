using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Panda : OrganicBeing, IPet
    {
        //string IPet.OwnersName
        //{
        //    get { return ""; }
        //}

        public void NameSelf()
        {
            Console.WriteLine($"Hi! My name is {Name}");
        }

        public Panda(string name)
        {
            Name = name;
            greeting = "GROOOWH";
        }
    }
}
