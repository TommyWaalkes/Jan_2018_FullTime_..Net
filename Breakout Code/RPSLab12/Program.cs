using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Rocky r = new Rocky();
            Console.WriteLine(r.GetName());
            Console.WriteLine(r.GenerateRPS());

            Randy ra = new Randy();
            Console.WriteLine(ra.GenerateRPS());
             Console.WriteLine(ra.GenerateRPS());
             Console.WriteLine(ra.GenerateRPS());
             Console.WriteLine(ra.GenerateRPS());
             Console.WriteLine(ra.GenerateRPS());
             Console.WriteLine(ra.GenerateRPS());
             Console.WriteLine(ra.GenerateRPS());
            Console.WriteLine(ra.GenerateRPS());
        }
    }
}
