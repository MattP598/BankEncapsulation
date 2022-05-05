using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();
            myAccount.Balance += 100;
        }
    }
}
