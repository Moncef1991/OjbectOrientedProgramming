using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperties
{
    class Managers:Employee
    {
        public string nameManager;

        public override void PrintName()
        {
            Console.WriteLine($"{name}");
        }
        public override void PrintDepart()
        {
            Console.WriteLine($"{department = "Managers"}");
        }
    }
}
