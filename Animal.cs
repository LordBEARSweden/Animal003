using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal003
{
   abstract class Animal
    {
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }


        public Animal(int age, int height, int weight, string color, string name)
        {
            Age = age;
            Height = height;
            Weight = weight;
            Color = color;
            Name = name;
             
        }
        public virtual string Stats()
        {
            return $"Age {Age} Height {Height} Weight {Weight} Color {Color} Name {Name}";
        }
        public abstract string DoSound();
    }
}
