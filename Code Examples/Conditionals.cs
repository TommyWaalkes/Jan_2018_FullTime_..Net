using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRaining = true;
            bool isCold = false;

            //If statements ask a yes or no question
            //If yes we do something, If no we do something else
            //What would the code look like if we wanted to check if it was raining AND cold?
            if(isRaining == true)
            {
                Console.WriteLine("It is raining! Grab an umbrella!");
            }
            else
            {
                Console.WriteLine("It is neither raining nor cold! No need for an umbrella!");
            }

            Console.WriteLine("Would you like a cookie?");
            String caseSwitch = Console.ReadLine();
            Console.WriteLine("Case Switch equals " +caseSwitch);
            //So switch statements work as a series of questions we ask about a single piece of data
            //We're accounting for a bunch of cases, and at the bottom we have a default case, which will 
            //catch anything we don't account for.

            //Think of it as short hand for a bunch of if-else blocks
            switch (caseSwitch)
            {
                case "yes":
                    Console.WriteLine("Here's a cookie!");
                    break;
                case "no":
                    Console.WriteLine("Okay, no cookies for you!");
                    break;
                case "maybe":
                    Console.WriteLine("Case maybe: come on, make up your mind!");
                    break;
                default:
                    Console.WriteLine("Default case: this is a catchall statement");
                    //challenge! How do make the switch statement get re-run if it doesn't understand the input?
                    Console.WriteLine("I'm sorry I don't understand what you're saying let's try again");
                    break;
            }

            //Under the hood this is what the switch statement is doing 
            //This is functionally identical to the above block
            if(caseSwitch == "yes")
            {
                Console.WriteLine("Case yes: Here I'll give you cookie");
            }
            else if(caseSwitch == "no")
            {
                Console.WriteLine("Case no: Okay you don't get a cookie");
            }
            else if(caseSwitch == "maybe")
            {
                Console.WriteLine("Case maybe: come on, make up your mind!");
            }
            else
            {
                Console.WriteLine("This is the default catch-all");
                Console.WriteLine("I'm sorry I don't understand what you're saying let's try again");
            }

        }
    }
}
