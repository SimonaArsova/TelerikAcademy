﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniamalHerarchy
{
    class Frog : Animal
    {
        public Frog(int age, Sex sex, string name) : base(age, sex, name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(this.Name + " says Kwack");
        }
    }
}
