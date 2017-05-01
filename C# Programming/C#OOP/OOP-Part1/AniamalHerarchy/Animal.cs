using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniamalHerarchy
{
    class Animal : ISound
    {
        private int age;
        Sex sex;
        private string name;

        public Animal(int age, Sex sex, string name)
        {
            this.Age = age;
            this.SexOfAnimal = sex;
            this.Name = name;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Ages can't be negative!");
                }
                this.age = value;
            }
        }

        public Sex SexOfAnimal
        {
            get
            {
                return this.sex;
            }
            set
            {
                this.sex = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Animal must have name");
                }
                this.name = value;
            }
        }

        virtual public void MakeSound()
        {
            Console.WriteLine("I'm Animal.");
        }
    }
}
