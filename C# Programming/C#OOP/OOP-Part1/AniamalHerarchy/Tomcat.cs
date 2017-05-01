using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniamalHerarchy
{
    class Tomcat : Cat
    {
        private Sex sex;

        public Tomcat(int age, Sex sex, string name) : base(age, sex, name)
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
                if (value != Sex.male)
                {
                    throw new ArgumentException("Tom is always male");
                }
                this.sex = value;

            }
        }
    }

}
