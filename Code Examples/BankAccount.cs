using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    class BankAccount
    {
        static void Main(string[] args)
        {
        }
        public static void Deposit(int amount) {

        }

        public static int Withdrawal(int amount)
        {
            if (amount <= 1000)
            {
                return amount;
            }
            else
            {
                return -1;
            }
            //return amount;
        }

        public static bool CheckPassword()
        {
            return false;
        }

    }
}
