using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLab12
{
    class Rocky : Player
    {
        public Rocky()
        {
            SetName("Rocky");
        }

        public override string GenerateRPS()
        {
            //throw new NotImplementedException();
            return "rock";
        }
    }
}
