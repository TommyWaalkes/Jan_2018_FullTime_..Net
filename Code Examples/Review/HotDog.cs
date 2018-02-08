using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTest
{
    class HotDog {

        public string Hot { get; set; }
        public string dog;
        public int cash;
        //Get default
        // return hot;

        //Set default
        // Hot = input;
        public HotDog()
        {
            dog = "weenie";
            Hot = "suuuuuper";
            
        }

        public string GetMustard()
        {
            string n = "mustard";
            return n;
        }
    }
}
