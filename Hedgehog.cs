using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal003
{
    class Hedgehog:Animal
    {
        public int NumberOfSpikes { get; set; }

        public Hedgehog(int age, int height, int weight, string color, string name, int numberOfSpikes) : base(age, height, weight, color, name)
        {
            NumberOfSpikes = numberOfSpikes;
        }

        public override string DoSound()
        {
            return "pip";
        }

        public override string Stats()
        {
            return base.Stats() + $" {NumberOfSpikes}";
        }
    }
}
