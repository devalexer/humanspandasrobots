using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanspandasrobots
{
    class Living
    {

        public string Food { get; set; }

        public void Eat()
        {
            Console.WriteLine($"Yum, I ate {Food}.");
        }

    }
}
