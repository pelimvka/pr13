using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1
{
    internal class Employee
    {
        private string name;
        private string post;
        private double salary;
        private string data;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Post
        {
            get { return post; }
            set { post = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        public Employee(string name, string post, double salary, string data)
        {
            Name = name;
            Post = post;
            Salary = salary;
            Data = data;
        }
        
    }
}
