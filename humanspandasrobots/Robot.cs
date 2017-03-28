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
        public bool IsAsleep { get; set; }
        public bool Terminator { get; set; }


        public void DisplayName()
        {
            Console.WriteLine($"My name is {Name}");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine($"My Greeting is: {Greeting}");
        }

        public void StartUp()
        {
            Console.WriteLine("Started...");
        }

        public void ShutDown()
        {
            Console.WriteLine("Shutdown...");
        }

        public bool IsTerminator()
        {
            Terminator = true;
            return true;
        }

        public bool GoToSleep()
        {
            IsAsleep = true;
            return true;
        }

        public bool WakeUp()
        {
            IsAsleep = false;
            return true;
        }

    }
}
