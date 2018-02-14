using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceClassDiagram
{
    public class Cars
    {
        public string model="RAV4";
        public string make="Toyota";
        public int year=2012;

        public void PrintModel()
        {
            Console.WriteLine($"{model}");
        }
    }
}