using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal003
{
    class Wolf:Animal
    {
        public int Fangs { get; set; }

        public Wolf(int age, int height, int weight, string color, string name, int fangs) :base(age, height, weight, color, name)
        {
            Fangs = fangs;
        }

        public override string DoSound()
        {
            return "Howl";
        }

        public override string Stats()
        {
            return base.Stats() + $" {Fangs}";
        }
    }
}
