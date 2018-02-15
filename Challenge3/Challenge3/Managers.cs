using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    class Managers:Employee
    {
        public string WhoIam = "I am Manager";

        public override void Print()
        {
            Console.WriteLine($"{WhoIam}");
        }
    }
}
