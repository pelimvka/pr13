using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._3
{
    class Book: LibraryItem
    {
        private string isbn;
        private int pages;
        public string ISBN
        {
            get {  return isbn; }
            set { isbn = value; }
        }
        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }
        public Book(string title, string author, int year, bool status, String isbn, int pages): base (title, author, year, status)
        {
            ISBN = isbn;
            Pages = pages;
        }
    }
}
