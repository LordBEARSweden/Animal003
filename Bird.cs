using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal003
{
    class Bird:Animal
    {
        public int TailFeahers { get; set; }

        public Bird(int age, int height, int weight, string color, string name, int tailfeathers) : base(age, height, weight, color, name)
        {
            TailFeahers = tailfeathers;
        }
        public override string DoSound()
        {
            return "Squik";
        }

        public override string Stats()
        {
            return base.Stats() + $" {TailFeahers}";
        }
    }
}
