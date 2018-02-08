using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Classes
{
    partial class EmployeesPart
    {
        public void printName() { Console.WriteLine($"Employee name is {name}"); }
        public void printAdress() { Console.WriteLine($"Employee adress is {adress}"); }
        partial void MyAge()
        {
            Console.WriteLine($"Employee age is {age}");
        }
        public void printDepart() { Console.WriteLine($"Employee departement is {departement}");
            MyAge();
        }
    }
}
