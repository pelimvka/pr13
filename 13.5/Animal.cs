using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._5
{
    class Animal
    {
        private string species;
        private int age;
        private string livingEnvironment;
        private string diet;
        public string Species
        {
            get { return species; }
            set { species = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string LivingEnvironment
        {
            get { return livingEnvironment; }
            set { livingEnvironment = value; }
        }
        public string Diet
        {
            get { return diet; }
            set { diet = value; }
        }
        public Animal(string species, int age, string livingEnvironment, string diet)
        {
            Species = species;
            Age = age;
            LivingEnvironment = livingEnvironment;
            Diet = diet;
        }
    }
}
