using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._2
{
    class BankAccount
    {
        private string account;
        private string name;
        private double balance;
        public string Account
        {
            get { return account; }
            set { account = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public BankAccount(string account, string name, double balance)
        {
            Account = account;
            Name = name;
            Balance = balance;
        }
        public void Deposit(double amount)
        {
            if (amount < 0) { Console.WriteLine("Сумма пополнения должна быть положительной!"); }
            else 
            {
                Balance += amount;
                Console.WriteLine($"Пользователь {Name} положил {amount}р. Баланс: {Balance}"); 
            }
        }
        public void Withdraw(double amount)
        {
            if (amount < 0) { Console.WriteLine("Сумма пополнения должна быть положительной!"); }
            else {
                Balance -= amount;
                Console.WriteLine($"Пользователь {Name} снял {amount}р. Баланс: {Balance}");
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Номер счёта: {Account}\nВладелец: {Name}\nБаланс: {Balance}");
        }
    }
}
