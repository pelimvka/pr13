using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Иван", "Менеджер", 80000, "15.06.2013", 10);
            manager.Sobr();
            Console.WriteLine();
            Developer developer = new Developer("Михаил", "Разработчик", 70000, "04.08.2014", "C#");
            developer.WriteCode();
            Console.WriteLine();
            Director director = new Director("Гоша", "Директор", 155000, "13.09.2010", "IT");
            director.ApproveBudget();
        }
    }
}
