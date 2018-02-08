using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() {"Jakey","Joey","Jimmy", "James"};
            string name = "tommy";
            names.Add(name);
            names.Add("hhhhhhehehehehe");
            names[0] = "jonathan";

            string[] ns = new string[] {"Wallace","William","Wookles" };
            ns[0] = "waalkes";
            

            HotDog d = new HotDog();
            Console.WriteLine(d.Hot = "hello");
            Console.WriteLine(d.dog = "Yes this is dog");
        }
    }
}
