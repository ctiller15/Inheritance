using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Being
    {
        public string greeting { get; set; } = "Hello!";
        public string Name { get; set; } = "name";
        public DateTime Birthday { get; set; } = new DateTime(1993, 5, 23);
        protected bool IsAsleep;

        public void SayHello()
        {
            Console.WriteLine($"{greeting}");
        }


        public override string ToString()
        {
            //return ($"{greeting} I am a {this.GetType().ToString().Replace(this.GetType().Namespace, "").Substring(1)}");
            //return (this.GetType().Name);
            return $"{greeting} I am a {this.GetType().Name} And I was born on {Birthday} I {(IsAsleep ? "am asleep" : "am not asleep")}";
        }



    }
}
