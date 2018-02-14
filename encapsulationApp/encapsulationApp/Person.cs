using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationApp
{
    class Person
    {
        private string name;
        private int age;
        public void PrintValues()
        {
            Console.WriteLine($"Name = {name} Age = {age}");
        }

        //Constructors
        public Person() { }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //Setters and getters methods
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setAge(int myAge)
        {
            age = myAge;
        }
        public int getAge()
        {
            return age ;
        }
    }
}
