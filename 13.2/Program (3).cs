using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._2
{
   class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount checking = new CheckingAccount("ABC123", "Dima", 150, 1000);
            checking.PrintInfo();
            Console.WriteLine();
            SavingsAccount saving = new SavingsAccount("HDG726", "Ivan", 500, 0.3);
            saving.PrintInfo();
            saving.Deposit(1000);
            saving.ProcentBet();
            Console.WriteLine();
            CreditAccount credit = new CreditAccount("HSP9191", "Nikitos", -300, 5000, "15.10.2026");
            credit.PrintInfo();
            credit.Deposit(2000);
            credit.Withdraw(1000);
        }
    }
}
