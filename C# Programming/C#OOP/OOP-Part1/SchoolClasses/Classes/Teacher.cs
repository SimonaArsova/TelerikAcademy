using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Teacher: Person, IPerson, ITeacher
    {
        private IList<IDiscipline> disciplines;
    
        public Teacher(string name):base(name)
        {
            disciplines = new List<IDiscipline>();
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }
        
        public void showDisciplines()
        {
            foreach (var item in disciplines)
            {
                Console.WriteLine(item);
            }
        }
        public override string ToString()
        {
            return string.Format("{0}: ", this.Name);
        }
    }
}
