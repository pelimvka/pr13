using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._5
{
    class Replite: Animal
    {
        private string skin;
        private double temperature;
        public String Skin
        {
            get { return skin; }
            set { skin = value; }
        }
        public double Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
        public Replite(string species, int age, string livingEnvironment, string diet, string skin, double temperature): base(species, age, livingEnvironment, diet)
        {
            Skin = skin;
            Temperature = temperature;
        }
    }
}
