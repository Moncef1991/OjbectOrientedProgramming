using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClassDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Toyota myObject = new Toyota();
            myObject.PrintModel();
            myObject.PrintEngineSize();

            Console.ReadKey();
        }
    }
}
