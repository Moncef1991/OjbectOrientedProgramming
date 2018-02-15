using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Ford:Cars
    {
        public string make = "Ford";

        public override void PrintMake()
        {
            Console.WriteLine($"{make}");
        }
    }
}
