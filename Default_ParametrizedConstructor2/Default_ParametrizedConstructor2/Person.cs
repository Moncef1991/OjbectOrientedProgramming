using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_ParametrizedConstructor2
{
    class Person
    {
        string name;
        int age;
        public void PrintValue() { Console.WriteLine($"{name}, {age}"); }

       //Default

        public Person()
        {
            name = "Moncef";
            age = 26;
        }

        //Parametrized constructor

        public Person(string value)
        {
            name = value;
            age = 26;
        }

        //Parametrized constructor

        public Person(string value2, int myAge)
        {
            name = value2;
            age = myAge;
        }
    }
}
