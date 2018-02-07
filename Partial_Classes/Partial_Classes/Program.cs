using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeesPart myEmployee = new EmployeesPart();
            myEmployee.printName();
            myEmployee.printAdress();
            myEmployee.printDepart();
            Console.ReadKey();
        }
    }
}
