using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _13._1
{
    internal class Manager: Employee
    {
        private int size;
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public Manager(string name, string post, double salary, string data, int size): base (name, post, salary, data)
        {
            Size = size;
        }
        public void Sobr()
        {
            Console.WriteLine($"Собрание из {Size} человек");
        }
       
    }
}
