using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._3
{
    class Magazine: LibraryItem
    {
        private int issueNumber;
        private string periodicity;
        public int IssueNumber
        {
            get { return issueNumber; }
            set { issueNumber = value; }
        }
        public string Periodicity
        {
            get { return periodicity; }
            set { periodicity = value; }
        }
        public Magazine(string title, string author, int year, bool status, int issueNumber, String periodicity): base (title, author, year, status)
        {
            IssueNumber = issueNumber;
            Periodicity = periodicity;
        }
    }
}
