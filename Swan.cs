using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal003
{
    class Swan:Bird
    {
        public int NeckLenght { get; set; }

        public Swan(int age, int height, int weight, string color, string name, int tailfeathers, int neckLenght) : base(age, height, weight, color, name, tailfeathers)
        {
            NeckLenght = neckLenght;
        }
    }
}
