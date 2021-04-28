using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal003
{
    class Horse:Animal
    {
        public string Breed { get; set; }

        public Horse(int age, int height, int weight, string color, string name, string breed) :base(age, height, weight, color, name)
        {
            Breed = breed;
        }
        

        public override string DoSound()
        {
            return "Gnäägg";
        }

        public override string Stats()
        {
            return base.Stats() + $" {Breed}";
        }
    }
}
