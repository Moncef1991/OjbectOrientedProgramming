using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperties
{
    class Department
    {
       

        public string departName { get; set; }
        public int departEmpNumber { get; set; }
        public int departRoomsNumb { get; set; } = 7;
        public Managers myMang { get; set; } 

        public Department()
        {
            //departRoomsNumb = 5;
            myMang = new Managers();
        }
        public Department(int number,Managers myMana )
        {
            departRoomsNumb = number;
            myMang = myMana;
        }
    }

}
