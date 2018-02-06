using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Customer : Person
    {
        private string Customer_ID = "111222333";
        private string payment_Info = "Cash";

        public Customer(string name, string ssn, string Customer_ID, string payment_Info) : base(name, ssn)
        {
            this.Customer_ID = Customer_ID;
            this.payment_Info = payment_Info;
            Console.WriteLine(this.name);
        }


        public override void GetInfo()
        {
            // Calling the base class GetInfo method:
            base.GetInfo();
            Console.WriteLine("Customer ID: {0}", Customer_ID);
            Console.WriteLine("Payment Method: {0}", payment_Info);
        }

        public override void PrintName()
        {
            Console.WriteLine(name + " Customer Id: " + Customer_ID);
        }
    }
}
