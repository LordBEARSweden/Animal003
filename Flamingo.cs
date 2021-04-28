using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal003
{
    class Flamingo:Bird
    {
        public string FeatherColor { get; set; }

        public Flamingo(int age, int height, int weight, string color, string name, int tailfeathers, string featherColor) : base(age, height, weight, color, name, tailfeathers)
        {
            FeatherColor = featherColor;
        }
    }
}
