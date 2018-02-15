using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myPerson = new Person();
            Employee myEmployee = new Employee();
            Managers myManager = new Managers();
            Financial myFinancial = new Financial();
            HR myHR = new HR();

            myPerson.Print();
            myEmployee.Print();
            myManager.Print();
            myFinancial.Print();
            myHR.Print();

            Console.ReadKey();
        }
    }
}
