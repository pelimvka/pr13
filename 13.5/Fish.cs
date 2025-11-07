using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._5
{
    class Fish: Animal
    {
        private string scalesType;
        private string depth;
        public string ScalesType
        {
            get { return scalesType; }
            set { scalesType = value; }
        }
        public string Depth
        {
            get { return depth; }
            set { depth = value; }
        }
        public Fish(string species, int age, string livingEnvironment, string diet, string scalesType, string depth): base(species, age, livingEnvironment, diet)
        {
            ScalesType = scalesType;
            Depth = depth;
        }
    }
}
