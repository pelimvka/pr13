using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._3
{
    class LibraryItem
    {
        private string title;
        private string author;
        private int year;
        private bool status;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        public LibraryItem(string title, string author, int year, bool status)
        {
            Title = title;
            Author = author;
            Year = year;
            Status = status;
        }
    }
}
