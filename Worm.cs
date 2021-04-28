using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal003
{
    class Worm:Animal
    {
        public bool IsPoisonus { get; set; }

        public Worm(int age, int height, int weight, string color, string name, bool isPoisonus) : base(age, height, weight, color, name)
        {
            IsPoisonus = isPoisonus;
        }

        public override string DoSound()
        {
            return "silence";
        }

        public override string Stats()
        {
            return base.Stats() + $" {IsPoisonus}";
        }
    }
}
