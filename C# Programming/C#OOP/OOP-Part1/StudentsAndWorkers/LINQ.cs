using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class LINQ
    {
        public static string OrderStudents(IList<Student> students)
        {
            var newStudents = students.OrderBy(s => s.Grade);
            return String.Join("\r\n", newStudents);
        }

        public static string OrderWorkers(IList<Worker> workers)
        {
            var newWorkers = workers.OrderByDescending(w => w.MoneyPerHour);
            return String.Join("\r\n", newWorkers);
        }
    }
}
