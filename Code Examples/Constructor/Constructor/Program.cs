using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //What this example will teach you: 
            //1) Constructors 
            //2) Instance Variable/Properties
            //3) Object Methods 

            //We're going to start jumping around to different files and places in our code 
            //But! The main method is still always the manager for the rest of our code 
            //Even in a 5000 file project it's the first method to be run
            //Also! There can only be one main method. Think of it as your front door.
            //It's like highlander: there can only be one

            //This is complaining why? What promise have we made the house constructor?
            House mansion = new House(40,4,true);

            //mansion.windowsCount = 10;
            // mansion.Furnish(true);

            mansion.SetWindowsCount(1000);

            mansion.PrintFuniture();

            House hut = new House(2,1,false);

            hut.PrintFuniture();

            Console.WriteLine();
            Console.WriteLine("Overwriting Mansion Variable");
            

            mansion.PrintFuniture();



        }
    }
}
