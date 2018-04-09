using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Robot : InorganicBeing, IPet
    {
        public string OwnersName { get; set; }

        public string VersionNumber { get; set; }

        public void NameSelf()
        {
            Console.WriteLine($"Hi! My name is {Name}");
        }

        public Robot(string name)
        {
            Name = name;
            greeting = "BZZZZT TERMINATE ALL HUMANS";
        }
    }
}
