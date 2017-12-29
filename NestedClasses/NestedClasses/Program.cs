using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees myEmployee = new Employees();
            myEmployee.PrintValues();
            Employees.Departements myDepart = new Employees.Departements();
            myDepart.PrintDepartementName();

            Console.ReadKey();
        }
    }
}
