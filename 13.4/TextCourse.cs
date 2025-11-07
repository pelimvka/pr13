using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._4
{
    class TextCourse: Course
    {
        private int chapters;
        private int volumeOfTheText;
        public int Chapters
        {
            get { return chapters; }
            set { chapters = value; }
        }
        public int VolumeOfTheText
        {
            get { return volumeOfTheText; }
            set { volumeOfTheText = value; }
        }
        public TextCourse(string title, string description, string author, int price, int chapters, int volumeOfTheText) : base(title, description, author, price)
        {
            Chapters = chapters;
            VolumeOfTheText = volumeOfTheText;
        }
    }
}
