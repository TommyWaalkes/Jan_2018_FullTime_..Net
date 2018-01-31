using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    [TestFixture]
    class TestBankAccount
    {
        //In these tests the Static Assert object will be your BFF
        [Test]
        public void WithdrawReturnsMoney()
        {
            int expected = 100;
            int actual = BankAccount.Withdrawal(100);
            Assert.AreEqual(expected, actual, "Withdrawing $100 Doesn't work");

            expected = 200; 
            actual = BankAccount.Withdrawal(200);
            Assert.AreEqual(expected, actual, "Withdrawing $200 Doesn't work");

            expected = -1;
            actual = BankAccount.Withdrawal(1001);
            Assert.AreEqual(expected, actual, "You shouldn't be able to withdraw more than 1000, but you just did");
        }

        [Test]
        public void DepositPutsMoneyIn()
        {
           
        }
    }
}
