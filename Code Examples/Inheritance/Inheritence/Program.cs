using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{


    class TestClass
    {
        static void Main()
        {
            Console.WriteLine("PERSON OBJECT OUTPUT");
            Person p = new Customer();

            Customer o = (Customer) p;
            o.GetInfo();
            Console.WriteLine();

            Console.WriteLine("EMPLOYEE OBJECT OUTPUT");
            Employee e = new Employee();
            e.GetInfo();
            Console.WriteLine();

            Console.WriteLine("CO-WORKER OUTPUT");
            Coworker cw = new Coworker();
            cw.GetInfo();
            Console.WriteLine();

            Console.WriteLine("CUSTOMER OBJECT OUTPUT");
            Customer c = new Customer();
            c.GetInfo();
            Console.WriteLine();

            Console.WriteLine("CITIZEN OBJECT OUTPUT");
            Citizen cz = new Citizen();
            cz.GetInfo();
            Console.WriteLine();



            // Polymorphism in action
            //Why are we able to add these three different types to our list? 
            List<Person> people = new List<Person>();
            people.Add(p);
            people.Add(e);
            people.Add(c);
            people.Add(cw);
            Console.WriteLine();
            Console.WriteLine("Print from the foreach Loop");
            foreach(Person n in people)
            {
                //Which version of getInfo() is being used?
                n.GetInfo();
                Console.WriteLine();
            }
        }
    }
}
