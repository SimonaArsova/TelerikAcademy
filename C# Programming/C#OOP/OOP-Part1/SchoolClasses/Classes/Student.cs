using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Student:Person, IPerson
    {
        private string classNumber;

        public Student(string name):base(name)
        {
            classNumber = GetId();
        }

        private string GetId()
        {
            var bytes = new byte[4];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            uint random = BitConverter.ToUInt32(bytes, 0) % 100000000;
            return String.Format("{0:D8}", random);
        }

        public override string ToString()
        {
            return string.Format("Class number: {0}; Name: {1}", classNumber, this.Name);
        }
    }
}
