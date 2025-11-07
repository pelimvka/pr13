using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._5
{
   class Bird: Animal
    {
        private string wing;
        private string nestingType;
        public string Wing
        {
            get { return wing; }
            set { wing = value; }
        }
        public string NestingType
        {
            get { return nestingType; }
            set { nestingType = value; }
        }
        public Bird(string species, int age, string livingEnvironment, string diet, string wing, string nestingType): base(species, age, livingEnvironment, diet)
        {
            Wing = wing;
            NestingType = nestingType;
        }
   }
}
