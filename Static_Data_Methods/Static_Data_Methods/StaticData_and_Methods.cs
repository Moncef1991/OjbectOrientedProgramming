using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Data_Methods
{
    class StaticData_and_Methods
    {
        //Static data at Instance-level
        public double currBalance;

        //A static point of data
        public static double currInterestRate ;

        //Parameterized constructor
        public StaticData_and_Methods(double balance)
        {
            
            currBalance = balance;
        }

        static StaticData_and_Methods()
        { currInterestRate = 0.5; }
        public static void SetInterestRate(double newRate)
        { currInterestRate = newRate; }

        public static double GetValue()
        { return currInterestRate; }
    }
}
