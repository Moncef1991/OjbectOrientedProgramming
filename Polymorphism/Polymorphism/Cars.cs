using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Cars
    {
        public string engineCapacity = "2.4L";
        public string drivingType = "4WD";

        public void PrintEngineCapacity()
        {
            Console.WriteLine($"{engineCapacity}");
        }
        public virtual void PrintMake()
        {
            Console.WriteLine($"{drivingType}");
        }
    }
}
