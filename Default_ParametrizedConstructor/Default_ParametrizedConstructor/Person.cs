using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_ParametrizedConstructor
{
    class Person
    {
        string name;
        int age;
        //Default
        public Person()
        {
            name = "Moncef";
            age = 26;
        }
        //Parametrized constructor
        Person(string value)
        {
            name = value;
        }
        //Parametrized constructor
        Person(string value2, int myAge)
        {
            name = value2;
            age = myAge;
        }

    }
}
