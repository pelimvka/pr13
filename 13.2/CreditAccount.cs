using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._2
{
    class CreditAccount: BankAccount
    {
        private double creditLimit;
        private string data;
        public double CreditLimit
        {
            get { return creditLimit; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Кредитный лимит должен быть положительный!");
                } else
                {
                    creditLimit = value;
                }
            }
        }
        public string Data
        {
            get { return data; }
            set { data  = value; }
        }
        public CreditAccount(string account, string name, double balance, double creditLimit, string data): base (account, name, balance)
        {
            CreditLimit = creditLimit;
            Data = data;
        }
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма снятия должна быть положительной!");
            }
            if (Balance - amount >= -CreditLimit)
            {
                Balance -= amount;
                Console.WriteLine($"Пользователь {Name} снял {amount}р. Баланс: {Balance}");
            }
            else
            {
                Console.WriteLine("Ошибка: Превышен кредитный лимит!");
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine("Кредитный счёт: ");
            base.PrintInfo();
            Console.WriteLine($"Кредитный лимит: {CreditLimit}");
            Console.WriteLine($"Срок погашения: {Data}");
        }
    }
}
