using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanspandasrobots
{
    class Robot : Creatures
    {

        public bool IsAsleep { get; set; }
        public bool Terminator { get; set; }


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

        public void CheckingOnSleepingPerson()
        {
            if (IsAsleep)
            {
                Console.WriteLine($"{Name} has been shut down.");
            }
            else
            {
                Console.WriteLine($"{Name} is NOT asleep.");
            }
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
