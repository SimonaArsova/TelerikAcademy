using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention_Methods_Delegates_Lambda_LINQ
{
    public class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int FN { get; private set; }
        public string Tel { get; private set; }
        public string Email { get; private set; }
        public List<int> Marks { get; private set; }
        public int GroupNumber { get; private set; }

        public Student(string fName, string lName, int fn, string tel, string email, List<int> marks, int grNumber)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = grNumber;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, FN:{2}, Tel:{3}, Email:{4}, Marks:{5}, Group number:{6}",
                FirstName, LastName, FN, Tel, Email, string.Join(", ", Marks), GroupNumber);
        }
    }
}
