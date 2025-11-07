using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._3
{
    class Audiobook: LibraryItem
    {
        private int duration;
        private string speaker;
        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public string Speaker
        {
            get { return speaker; }
            set { speaker = value; }
        }
        public Audiobook(string title, string author, int year, bool status, int duration, string speaker): base (title, author, year, status)
        {
            Duration = duration;
            Speaker = speaker;
        }
    }
}
