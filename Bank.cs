using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventdemo2
{
    public delegate void BankDelegate(string message);

    public class Bank
    {
        public event BankDelegate BankEvent;

        public void Notify(string message)
        {
            if (BankEvent != null)
                BankEvent(message);
        }
    }
}
