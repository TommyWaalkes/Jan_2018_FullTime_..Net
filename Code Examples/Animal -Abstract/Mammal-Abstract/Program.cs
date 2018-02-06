using System;

namespace AnimalAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            Cat c = new Cat();
            Chimp m = new Chimp();
            Llama l = new Llama();
            Goat g = new Goat();
            VelociaRaptor r = new VelociaRaptor();
            Husky h = new Husky();

            Console.WriteLine(d.MakeSound());
            Console.WriteLine("The dog eats "+d.GetFood());
            Console.WriteLine(c.MakeSound());
            Console.WriteLine("The cat eats "+c.GetFood());
            Console.WriteLine(m.MakeSound());
            Console.WriteLine("The chimp eats " + m.GetFood());

            Console.WriteLine(l.MakeSound());
            Console.WriteLine("The llama eats " + l.GetFood());

            Console.WriteLine(g.MakeSound());
            g.PrintFood();

            Console.WriteLine(r.GetFood());
            Console.WriteLine(r.MakeSound());
            r.PrintFood();
            Console.WriteLine(h.GetFood());
            Console.WriteLine(h.MakeSound());
        }
    }
}