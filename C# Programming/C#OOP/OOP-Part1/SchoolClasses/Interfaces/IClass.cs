using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses.Interfaces
{
    interface IClass
    {
        Teacher[] Teachers { get; set;}
        Student[] Students { get; set; }

        void AddStudent(Student student);
        void AddTeacher(ITeacher teacher);
    }
}
