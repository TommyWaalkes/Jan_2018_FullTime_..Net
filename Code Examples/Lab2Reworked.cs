	using System;

public class Lab2Reworked
{
    public static void Main()
    {
        Boolean run = true;

        while (run == true)
        {
            Console.WriteLine("Hello, Please input a number from 1 to 100");
            int num = int.Parse(Console.ReadLine());
            PrintNumberInfo(num);
            run = Continue();
        }

    }

    public static void PrintNumberInfo(int i)
    {
        if (i >= 1 && i <= 100)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(i + " Odd");
            }
            else if (i % 2 == 0)
            {
                if (i <= 25 && i >= 2)
                {
                    Console.WriteLine("Even and Less than 25");
                }
                else if ((i >= 26) && (i <= 100))
                {
                    Console.WriteLine("Even");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input, please a enter a number between 1 and 100");
        }
    }

    public static Boolean Continue()
    {
        Console.WriteLine("Continue? Y/N");
        string input = Console.ReadLine();
        Boolean run = false; 
        input.ToLower();

        if(input == "n")
        {
            Console.WriteLine("Good bye");
            run = false;
        }
        else if(input =="y")
        {
            run = true;
        }
        else
        {
            Console.WriteLine("I'm sorry I didn't under your input let's try that again");
            run = Continue();
        }

        return run;
    }
}