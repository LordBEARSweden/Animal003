using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal003
{
    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            throw new ArgumentException("You tried to use a text input in a numericonly field.This fired an error!");
        }
    }
}
