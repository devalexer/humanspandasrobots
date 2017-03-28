using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanspandasrobots
{
    class Program
    {
        static void Main(string[] args)
        {

            var jane = new Human();
            jane.Name = "Jane";
            jane.Greeting = "Howdy!";
            jane.Food = "Steak";
            jane.IsAsleep = true;

            jane.DisplayName();
            jane.DisplayGreeting();
            jane.Eat();
            jane.GoToSleep();
            jane.WakeUp();
            jane.CheckingOnSleepingPerson();


            var baobao = new Panda();
            baobao.Name = "BaoBao";
            baobao.Greeting = "Grrrr!";
            baobao.Food = "Bamboo";
            baobao.IsAsleep = true;

            baobao.DisplayName();
            baobao.DisplayGreeting();
            baobao.Eat();
            baobao.GoToSleep();
            baobao.WakeUp();


            var marvin = new Robot();
            marvin.Name = "Marvin the Android";
            marvin.Greeting = "Greetings!";
            marvin.IsAsleep = false;
            marvin.Terminator = false;

            marvin.DisplayName();
            marvin.DisplayGreeting();
            marvin.IsTerminator();
            marvin.GoToSleep();
            marvin.WakeUp();





        }
    }
}
