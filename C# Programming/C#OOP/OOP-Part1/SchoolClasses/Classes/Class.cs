using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
   public class Class
    {
        private IList<ITeacher> teachers;
        private IList<Student> students;
        private string classID;

        public Class()
        {
            teachers = new List<ITeacher>();
            students = new List<Student>();
            this.classID = RandomString(6);
        }

        public ITeacher[] Teachers
        {
            get
            {
                return this.teachers.ToArray();
            }
        }
        public Student[] Students   
        {
            get
            {
                return this.students.ToArray();
            }
        }

        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public void AddTeacher(ITeacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public override string ToString()
        {
            return String.Format("Class ID: " + this.classID + "\n===============================");
        }

    }
}
