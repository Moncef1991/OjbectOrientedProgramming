using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClasses
{
    class Employees
    {
        public string fName = "Oussaf Moncef";
        public string adress = " City Chikhi";
        public void PrintValues() { Console.WriteLine($"Employee name is {fName} \nLiving at {adress}"); }
        public class Departements
        {
            public string departementName = "administration";
            public void PrintDepartementName() { Console.WriteLine($"Working at {departementName}"); }
        }
    }
}
