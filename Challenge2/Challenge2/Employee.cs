using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge2
{
    public class Employee : Person
    {
        public string adress = "Rue M N° 4 , Batna";

        public void PrintAdress()
        {
            Console.WriteLine($"Adress is : {adress}");
        }
    }
}