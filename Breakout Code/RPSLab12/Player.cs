using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLab12
{
    abstract class Player
    {
        private string name;

        public Player()
        {
            SetName("player");
        }

        public abstract string GenerateRPS();

        protected void SetName(string n)
        {
            name = n;
        }

        public string GetName()
        {
            return name;
        }
    }
}
