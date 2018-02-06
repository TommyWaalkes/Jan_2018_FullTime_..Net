using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Person
    {
        protected string ssn = "444-55-6666";
        protected string name = "Sarah P. Conor";

        public Person(string name, string ssn)
        {
            this.name = name;
            this.ssn = ssn;

        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("SSN: " + ssn);
        }

        public virtual void PrintName()
        {
            Console.WriteLine(name);
        }

        public void DrinkWater()
        {
            Console.WriteLine(name + " drank water");
        }
    }
}
