using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal003
{
    class WolfMan : Wolf, IPerson
    {

        public WolfMan(int age, int height, int weight, string color, string name, int fangs) : base(age, height, weight, color, name, fangs)
        {

        }
        public void Talk()
        {
            System.Console.WriteLine("Grr I am WolfMan");
        }
    }
}
