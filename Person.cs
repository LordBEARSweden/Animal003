using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal003
{
    class Person
    {
        private string fName;

        public string FName
        {
            get { return FName; }
            set 
            {
                if (value.Length > 2 && value.Length < 10 && value != null )
                {
                    fName = value;
                }
                else
                {
                    throw new ArgumentException("Not a valid input!");
                }               
            }
        }

        private string lName;

        public string LName
        {
            get { return LName; }
            set 
            {
                if (value.Length >= 3 && value.Length <= 15 && value != null)
                {
                   lName = value; 

                }
                else
                {
                    throw new ArgumentException("Not a valid input");
                }
            }
        }

        public int Height { get; set; }
        public int Weight { get; set; }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 1)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Not a valid input!");
                }
            }
        }
    }
}
