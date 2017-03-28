using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanspandasrobots
{
    class Human
    {
        public string Name { get; set; }
        public string Greeting { get; set; }
        public string Food { get; set; }
        public bool IsAsleep { get; set; }


        public void DisplayName()
        {
            Console.WriteLine($"My name is {Name}");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine($"My Greeting is: {Greeting}");
        }

        public void Eat()
        {
            Console.WriteLine($"Yum, I ate {Food}.");
        }

        public void CheckingOnSleepingPerson()
        {
            if (IsAsleep)
            {
                Console.WriteLine($"{Name} is asleep.");
            }
            else
            {
                Console.WriteLine($"{Name} is NOT asleep.");
            }
        }

        public bool GoToSleep()
        {
            IsAsleep = true;
            return IsAsleep;
        }

        public bool WakeUp()
        {
            IsAsleep = false;
            return IsAsleep;
        }
    }
}
