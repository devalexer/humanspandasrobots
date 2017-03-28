using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanspandasrobots
{
    class Creatures
    {

        public string Name { get; set; }
        public string Greeting { get; set; }


        public void DisplayName()
        {
            Console.WriteLine($"My name is {Name}.");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine($"My Greeting is: {Greeting}.");
        }
    }
}
