using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanspandasrobots
{
    class Panda
    {
        //Create a class definition for a Human, a Robot, and a Panda in separate files.

        //All classes should have a "DisplayName()" and a "DisplayGreeting()" method.
        //The "DisplayName()" function should return the value held in the property "Name".


        public string Name { get; set; }
        public string Greeting { get; set; }


        public string DisplayName()
        {
            return this.Name;
        }

        public string DisplayGreeting()
        {
            return $"{Greeting}";
        }

    }
}
