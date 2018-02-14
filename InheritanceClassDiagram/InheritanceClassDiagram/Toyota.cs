using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceClassDiagram
{
    public class Toyota : Cars
    {
        public int engineSize=3;

        public void PrintEngineSize()
        {
            Console.WriteLine($"{engineSize}");
        }
    }
}