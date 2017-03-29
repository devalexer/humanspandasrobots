using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanspandasrobots
{
    class Panda : Creatures, ILiving 
    {

        public string Food { get; set; }
        public bool IsAsleep { get; set; }


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
