using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {

            Managers myManagObj = new Managers();
            myManagObj.nameManager = "Said";

            Department myDep = new Department();

            myDep.departEmpNumber = 12;
            myDep.departName = "Managers";
            myDep.myMang = myManagObj;

            Console.WriteLine($"{myDep.departEmpNumber} \n{myDep.departName}");
            Console.WriteLine($"{myDep.departRoomsNumb}\n{myDep.myMang.nameManager}");


            Console.ReadKey();
        }
    }
}
