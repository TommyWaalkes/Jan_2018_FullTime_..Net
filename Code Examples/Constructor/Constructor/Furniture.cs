using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Furniture
    {
        string name { get; set; }
        //How do I re-work this Object so that I can only make chairs, tables, and beds? 
        public Furniture(string name)
        {
            this.name = name;
        }

        public void PrintName()
        {
            Console.WriteLine(name);
        }
    }
}
