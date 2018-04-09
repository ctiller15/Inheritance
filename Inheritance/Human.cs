using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Human : OrganicBeing
    {
        public List<IPet> Pets { get; set; } = new List<IPet>();

        public void Adopt(IPet pet)
        {
            //pet.OwnersName = this.Name;
            Pets.Add(pet);
            foreach(var Pet in Pets)
            {
                Pet.NameSelf();
            }
        }

        public Human()
        {
            greeting = "Hello there friend!!!";
        }
    }
}
