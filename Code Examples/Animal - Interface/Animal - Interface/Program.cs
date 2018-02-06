using System;
using System.Collections.Generic;

namespace AnimalInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine(f.GetFood());

            List<IAnimal> animals = new List<IAnimal>();
            Fox f = new Fox();
            Dog d = new Dog();
            Cat c = new Cat();
            Chimp ch = new Chimp();
            Elephant e = new Elephant();
            

            animals.Add(d);
            animals.Add(c);
            animals.Add(ch);
            animals.Add(f);

            foreach(IAnimal a in animals)
            {
                Console.WriteLine(a.GetFood());
                Console.WriteLine(a.MakeSound());
            }

            Console.WriteLine(d.MakeSound());
            Console.WriteLine("The dog eats " + d.GetFood());

            Console.WriteLine();
            Console.WriteLine("Kitty call!");
            Console.WriteLine(c.MakeSound());
            Console.WriteLine("The cat eats " + c.GetFood());

            Console.WriteLine("Chimp Methods");
            Console.WriteLine(ch.MakeSound());
            Console.WriteLine("The chimp eat "+ch.GetFood());

            Console.WriteLine("Elephant Methods");
            Console.WriteLine(e.MakeSound());
            Console.WriteLine("The Elephant eats " +e.MakeSound());
        }
    }
}