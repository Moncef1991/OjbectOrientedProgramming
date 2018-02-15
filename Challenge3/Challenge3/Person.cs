using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    class Person
    {
        public string whoIam = "I am a Person";

        public virtual void Print()
        {
            Console.WriteLine($"{whoIam}");
        }
    }
}
