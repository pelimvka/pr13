using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._2
{
    class SavingsAccount: BankAccount
    {
        private double procent;
        public double Procent
        {
            get { return procent; }
            set
            {
                if (value >= 0) { procent = value; }
                else { Console.WriteLine("Процентная ставка должна быть положительная!"); }
            }
        }
        public SavingsAccount(string account, string name, double balance, double procent): base (account, name, balance)
        {
            Procent = procent;
        }
        public void ProcentBet()
        {
            double proc = Balance * Procent / 100;
            Balance += proc;
            Console.WriteLine($"На счет владельца {Name} были начислены проценты в размере {proc}. Баланс: {Balance}");
        }
        public void PrintInfo()
        {
            Console.WriteLine("Сберегательный счёт: ");
            base.PrintInfo();
            Console.WriteLine($"Процентная ставка: {Procent}");
        }
    }
}
