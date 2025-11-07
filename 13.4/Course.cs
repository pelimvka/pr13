using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._4
{
    class Course
    {
        private string title;
        private string description;
        private string author;
        private int price;
        public string Title
        {
            get {  return title; }
            set { title = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public String Author
        {
            get { return author; }
            set { author = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public Course(string title, string description, string author, int price)
        {
            Title = title;
            Description = description;
            Author = author;
            Price = price;
        }
    }
}
