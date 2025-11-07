using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1
{
    internal class Director: Employee
    {
        private string department;
        public string Department
        {
            get {  return department; }
            set { department = value; }
        }
        public Director(string name, string post, double salary, string data, string department): base(name, post, salary, data)
        {
            Department = department;
        }
        public void ApproveBudget()
        {
            Console.WriteLine($"Утвердил бюджет {Department} отдела");
        }
       
    }
}
