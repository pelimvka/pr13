using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._2
{
    class CheckingAccount: BankAccount
    {
        private int overdraftLimit;
        public int OverdraftLimit
        {
            get { return overdraftLimit; }
            set { overdraftLimit = value; }
        }
        public CheckingAccount(string account, string name, int balance, int overdraftLimit): base(account, name, balance)
        {
            OverdraftLimit = overdraftLimit;
        }
        public void Withdraw(double amount)
        {
            if (amount < 0) 
            {
                Console.WriteLine("Сумма снятия должна быть положительной!"); 
            }
            if (amount <= Balance + OverdraftLimit)
            {
                Balance -= amount;
                Withdraw(amount);
            }
            else 
            {
                Console.WriteLine("Привышен лимит овердрафта!");
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine("Текущий счет: ");
            base.PrintInfo();
            Console.WriteLine($"Лимит овердрафта: {OverdraftLimit}");
        }
    }
}
