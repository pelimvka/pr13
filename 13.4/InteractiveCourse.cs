using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._4
{
    class InteractiveCourse: Course
    {
        private int numberOfExercises;
        private String assessmentSystem;
        public int NumberOfExercises
        {
            get { return numberOfExercises; }
            set { numberOfExercises = value; }
        }
        public String AssessmentSystem
        {
            get { return assessmentSystem; }
            set { assessmentSystem = value; }
        }
        public InteractiveCourse(string title, string description, string author, int price, int numberOfExercises, String assessmentSystem) : base(title, description, author, price)
        {
            NumberOfExercises = numberOfExercises;
            AssessmentSystem = assessmentSystem;
        }
    }
}
