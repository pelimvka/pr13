using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._3
{
    class DVD: LibraryItem
    {
        private int duration;
        private string rating;
        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public string Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        public DVD(string title, string author, int year, bool status, int duration, string rating): base (title, author, year, status)
        {
            Duration = duration;
            Rating = rating;
        }
    }
}
