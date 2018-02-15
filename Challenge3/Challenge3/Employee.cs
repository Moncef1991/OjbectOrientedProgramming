using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    class Employee:Person
    {
        public string WhoIam="I am Employee";
       
        public override void Print()
        {
            Console.WriteLine($"{WhoIam}");
        }

    }
}
