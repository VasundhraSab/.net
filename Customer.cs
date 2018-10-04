using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventdemo2
{
    public class Customer
    {
        public int Balance { get; set; }
        public Customer (int balance)
        {
            Balance = balance;
        }

        public void withdraw(int amount)
        {
            string message = "";



            if (Balance > amount)
            {
                Balance = Balance - amount;
                message = ("After deducting" + amount + "remaining balance is" + Balance );
            }
            else
            {
                message = "You are trying to withdraw greater amount than balance";
            }

            Bank b = new Bank();
            b.BankEvent += SMSGateway.SendMessage;

            b.Notify(message);
        }
    }
}
