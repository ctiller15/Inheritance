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
        }
    }
}
