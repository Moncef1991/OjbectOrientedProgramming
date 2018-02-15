using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars myCarsObject = new Cars();
            Toyota myToyotaObject = new Toyota();
            Nissan myNissanObject = new Nissan();
            Ford myFordObject = new Ford();

            myCarsObject.PrintMake();
            myFordObject.PrintMake();
            myNissanObject.PrintMake();
            myToyotaObject.PrintMake();

            Console.ReadKey();

        }
    }
}
