using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal003
{
    class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        
        public void SetFName(Person pers, string fName)
        {
            pers.FName = fName;
        }

        public void SetLName(Person pers, String lName)
        {
            pers.LName = lName;
        }

        public void SetHeight(Person pers, int height)
        {
            pers.Height = height;
        }

        public void SetWeight(Person pers, int weight)
        {
            pers.Weight = weight;
        }

        public Person CreatePerson(int age, string fName, string lName, int height, int weight)
        {
            var person = new Person();
            SetAge(person, age);
            SetFName(person, fName);
            SetLName(person, lName);
            SetHeight(person, height);
            SetWeight(person, weight);
            
            return person;
        }

    }
}
