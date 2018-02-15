using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    class Financial:Employee
    {
        public string WhoIam = "I am in Financial";

        public override void Print()
        {
            Console.WriteLine($"{WhoIam}");
        }
    }
}
