using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Data_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticData_and_Methods s1 = new StaticData_and_Methods(50);
      
            //Print the current interest rate
            Console.WriteLine("Interest rate is : {0}", StaticData_and_Methods.GetValue());
            StaticData_and_Methods.SetInterestRate(0.7);

            //Even if we make new object, this does not 'reset' the interest rate
            StaticData_and_Methods s3 = new StaticData_and_Methods(200);
            Console.WriteLine("Intesrest rate is : {0}", StaticData_and_Methods.GetValue());
            Console.ReadKey();
        }
    }
}
