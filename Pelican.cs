using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal003
{
    class Pelican:Bird
    {
        public int WingSpan { get; set; }

        public Pelican(int age, int height, int weight, string color, string name, int tailfeathers, int wingSpan) : base(age, height, weight, color, name, tailfeathers)
        {
            WingSpan = wingSpan;
        }
    }
}
