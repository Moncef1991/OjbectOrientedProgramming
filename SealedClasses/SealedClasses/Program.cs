using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Managers myMang = new Managers();
            HR myHRD = new HR();
            PTEmployees myPTE = new PTEmployees();

            myMang.name = "Monsif";
            myHRD.name = "Badis";

            myMang.PrintName();
            myMang.PrintDepart();

            myHRD.PrintName();
            myHRD.PrintDepart();
            myPTE.shift = "Day";
            Console.WriteLine($"{myPTE.shift}");

            Console.ReadKey();
        }
    }
}
