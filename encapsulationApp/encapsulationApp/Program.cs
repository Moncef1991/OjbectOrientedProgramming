using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Monsif Oussaf";
            int age = 26;
            Person myObject = new Person();
            myObject.setName(name);
            myObject.setAge(age);

            Console.WriteLine("Name is " + myObject.getName());
            Console.WriteLine("Age is " + myObject.getAge());
            Console.ReadKey();
        }
    }
}
