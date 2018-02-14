using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Toyota myObject = new Toyota();
            myObject.make = "Ford";
            myObject.year = "2013";
            myObject.PrintModel();
            myObject.PrintEngineSize();
            Console.WriteLine($"{myObject.make}");

            Console.ReadKey();


        }
    }
}
