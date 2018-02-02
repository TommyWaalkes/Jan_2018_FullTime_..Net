using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class House
    {
        private int windowsCount { get; set; }
        private int floorsCount { get; set; }
        private string color { get; set; }
        private bool expensiveTaste { get; set; }
        //What other things would a house need to care about?

        private List<Furniture> currentFurniture = new List<Furniture>();

        //We need to set the color in the contstructor, how do we do that? 
        //How would you only let Red, Black, and Blue be accepted as colors?
        public House(int windows, int floors, bool taste)
        {
            windowsCount = windows;
            floorsCount = floors;
            expensiveTaste = taste;
            Furnish(expensiveTaste);
        }

        private void Furnish(bool ExpensiveTaste)
        {
            if(ExpensiveTaste == true)
            {
                currentFurniture.Add(new Furniture("5000in FlatScreen"));
                currentFurniture.Add(new Furniture("Memory Foam Chair"));
                currentFurniture.Add(new Furniture("Diamond Matress"));

            }
            else
            {
                currentFurniture.Add(new Furniture("Metal Folding Chair"));
                currentFurniture.Add(new Furniture("Card Table"));
                currentFurniture.Add(new Furniture("5000lbs CRT"));
            }

        }

        public void PrintFuniture()
        {
            Console.WriteLine();
            if (expensiveTaste)
            {
                Console.WriteLine("This House is well Decorated");
            }
            else
            {
                Console.WriteLine("This House is minimally Decorated");
            }
            foreach(Furniture f in currentFurniture)
            {
                f.PrintName();
            }

        }

        public int GetWindowsCount()
        {
            return windowsCount;
        }

        public void SetWindowsCount(int windowsCount)
        {
            this.windowsCount = windowsCount;
        }

    }
}
