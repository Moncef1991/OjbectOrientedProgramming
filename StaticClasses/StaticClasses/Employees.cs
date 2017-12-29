using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    static class Employees
    {
        static public string name = "Mncef Oussaf";
        static public int age = 26;

        static public void PrintName()
        {
            Console.WriteLine($"Name : {name} , Age : {age}");
        }
    }
}
