using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._4
{
    class VideoCourse: Course
    {
        private int numberOfVideos;
        private double totalDuration;
        public int NumberOfVideos
        {
            get { return numberOfVideos; }
            set { numberOfVideos = value; }
        }
        public double TotalDuration
        {
            get { return totalDuration; }
            set { totalDuration = value; }
        }
        public VideoCourse(string title, string description, string author, int price, int numberOfVideos, double totalDuration): base (title, description, author, price)
        {
            NumberOfVideos = numberOfVideos;
            TotalDuration = totalDuration;
        }
    }
}
