using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniamalHerarchy
{
    class Kitten : Cat
    {
        private Sex sex;
        public Kitten(int age, Sex sex, string name) : base(age, sex, name)
        {
            SexOfAnimal = sex;

        }

        public new Sex SexOfAnimal
        {
            get
            {
                return this.sex;
            }
            set
            {
                if (value != Sex.female)
                {
                    throw new ArgumentException("Kitten is always female");
                }
                this.sex = value;
                
            }
        }

    }
}
