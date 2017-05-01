using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniamalHerarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(3,Sex.male, "Suzi");
            Cat anotherCat = new Cat(1, Sex.female, "Maca");
            cat.MakeSound();
            Dog dog = new Dog(5, Sex.female, "Lisa");
            Dog anotherDog = new Dog(6, Sex.male, "Sharo");
            dog.MakeSound();
            Frog frog = new Frog(3, Sex.male, "Kermit");
            frog.MakeSound();
            Kitten kitty = new Kitten(2, Sex.female, "Kitty");
            kitty.MakeSound();
            Tomcat tom = new Tomcat(4, Sex.male, "Tom");
            tom.MakeSound();

            List<Animal> animals = new List<Animal>();
            animals.Add(cat);
            animals.Add(anotherCat);
            animals.Add(dog);
            animals.Add(anotherDog);
            animals.Add(frog);
            animals.Add(kitty);
            animals.Add(tom);

            CalculateAge(animals);

        }


        public static void CalculateAge(List<Animal> animalList)

        {
            var temp =
                from animals in animalList
                group animals by animals.GetType().Name into groups
                select new
                {
                    AnimalKind = groups.Key,
                    AverageAge = groups.Average(animals => animals.Age).ToString("0.00")
                };

            Console.WriteLine();

            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    
    }
}
