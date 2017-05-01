using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniamalHerarchy
{
    class Dog : Animal
    {
        public Dog(int age, Sex sex, string name) : base(age, sex, name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(this.Name + " says Bow");
        }
    }
}
