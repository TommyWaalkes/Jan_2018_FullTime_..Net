using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    class Cat : IAnimal
    {
        public string GetFood()
        {
            return "mice";
        }

        public string MakeSound()
        {
            return "meow";
        }
    }
}
