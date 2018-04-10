using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Adoption
    {
        static string AdoptionPrompt()
        {
            Console.WriteLine("Would you like to adopt a Robot or a Panda?\n" +
                "(1) Robot\n" +
                "(2) Panda\n");

            string choice = Console.ReadLine();
            return choice;
        }

        static string GetAdoptedName()
        {
            Console.WriteLine("What is the name of your pet?");
            string name = Console.ReadLine();
            return name;
        }

        static private bool AdoptPet(string Choice, string Name, Human human)
        {
            if(Choice == "1")
            {
                human.Adopt(new Robot(Name));
                return true;
            } else if(Choice == "2")
            {
                human.Adopt(new Panda(Name));
                return true;
            } else
            {
                Console.WriteLine("You didn't specify which pet you wanted! You don't get a pet!");
                return false;
            }
        }

        // A method that wraps around the other adoption-related methods.
        static public void ManageAdoption(Human human)
        {
            bool adopted = false;
            while (!adopted)
            {
                string petChoice = AdoptionPrompt();
                string petName = GetAdoptedName();
                adopted = AdoptPet(petChoice, petName, human);
                human.ShowPets();
            }
        }
    }
}
