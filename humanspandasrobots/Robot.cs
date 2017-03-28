using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanspandasrobots
{
    class Robot
    {
        public string Name { get; set; }
        public string Greeting { get; set; }
        public bool WasShutDown { get; set; }


        public string DisplayName()
        {
            return this.Name;
        }

        public string DisplayGreeting()
        {
            return $"{Greeting}";
        }

        public string StartUp()
        {
            return "Started...";
        }

        public string ShutDown()
        {
            return "Shutdown...";
        }

        public bool IsTerminator()
        {
            return $"{}, Robot is terminator.";
        }

        //    All classes should have a "IsASleep" property which returns true/false on the following conditions:

        //if it's a panda or a human - then return true if the property 'ASleep' is true
        //if it's a robot - return true if it has been shutdown.

        public bool IsAsleep()
        {
            if (WasShutDown == true);
            return true;
        }
    }
}
