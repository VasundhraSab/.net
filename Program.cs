using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventdemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer(100000);

            Console.Write("Please enter the amount to withdraw");
            int amount = Convert.ToInt32(Console.ReadLine());

            c.withdraw(amount);

            //Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}
