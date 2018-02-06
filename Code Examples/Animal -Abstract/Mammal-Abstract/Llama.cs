using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstract
{
    class Llama : Animal
    {
        public override string GetFood()
        {
            return "fruit";
        }

        public override string MakeSound()
        {
            return "Meuooooooowah";
        }


    }
}
