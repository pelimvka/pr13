using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._5
{
    class Mammal: Animal
    {
        private string furType;
        private string gestationPeriod;
        public string FurType
        {
            get { return furType; }
            set { furType = value; }
        }
        public string GestationPeriod
        {
            get { return gestationPeriod; }
            set { gestationPeriod = value; }
        }
        public Mammal(string species, int age, string livingEnvironment, string diet, string furType, string gestationPeriod): base (species, age, livingEnvironment, diet)
        {
            FurType = furType;
            GestationPeriod = gestationPeriod;
        }
    }
}
