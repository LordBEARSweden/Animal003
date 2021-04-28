using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Animal003
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonHandler personHandler = new PersonHandler();
            personHandler.CreatePerson(54, "Kalle", "Anka", 50, 32);
            personHandler.CreatePerson(39, "Björn", "Andersson", 174, 80);

           /* try
            {
                //Console.WriteLine($"{person.FName} {person.LName} {person.Age} {person.Height} {person.Weight}");
                Console.WriteLine();
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
                //throw;
            }*/

            Horse horse = new Horse(2, 80, 220, "Brown", "Månella", "Ardenner");
            Wolf wolf = new Wolf(4, 40, 60, "Gray", "Wolfie", 32);
            Swan swan = new Swan(1, 32, 10, "White", "Goose", 40, 20);
            Dog dog = new Dog(3, 20, 12, "Black", "Fido", "Collie");
            List<Animal> ListAnimal = new List<Animal>();
            List<Dog> ListDog = new List<Dog>();

            ListDog.Add(dog);

            ListAnimal.Add(horse);
            ListAnimal.Add(swan);
            ListAnimal.Add(wolf);
            foreach (Animal animal in ListAnimal)
            {
                if (animal is IPerson)
                {
                    var person = (IPerson)animal;
                    person.Talk();
                }
                else
                {
                    Console.WriteLine(animal.Stats());
                 Console.WriteLine(animal.DoSound());

                }
            }
            Console.WriteLine(dog.Stats());
        }
    }
}
