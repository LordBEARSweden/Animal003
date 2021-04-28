using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal003
{
    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            throw new ArgumentException("you tried to use a numeric input in a text only field. This fired an error!");
        }
    }
}
