using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLab12
{
    class Randy : Player
    {
        Random r = new Random();

        public Randy()
        {
            SetName("Randy");
        }

        public override string GenerateRPS()
        {
            int choice = r.Next(1, 4);
            string output = "rock";


            switch (choice)
            {
                case 1: output = "rock";
                break;
                case 2: output = "paper";
                break;
                case 3: output = "scissors";
                break;
            }

            return output;
        }
    }
}
