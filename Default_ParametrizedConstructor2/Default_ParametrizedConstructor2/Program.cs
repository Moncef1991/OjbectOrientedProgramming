using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_ParametrizedConstructor2
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Mounir";
            int age2 = 22;
            string myName2 = "Badis";

            Person myObject = new Person();
            myObject.PrintValue();
            Console.WriteLine();

            Person myObject2 = new Person(myName, age2);
            myObject2.PrintValue();
            Console.WriteLine();

            Person myObject3 = new Person(myName2);
            myObject3.PrintValue();

            Console.ReadKey();
        }
    }
}
