using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Managers myMang = new Managers();
            HRD myHRD = new HRD();

            myMang.name = "Monsif";
            myHRD.name = "Badis";

            myMang.PrintName();
            myMang.PrintDepartment();

            myHRD.PrintName();
            myHRD.PrintDepartment();

            Console.ReadKey();
        }
    }
}
