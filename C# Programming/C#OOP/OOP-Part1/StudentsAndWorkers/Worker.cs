using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Worker: Human
    {
        public Worker(string firstname, string lastname, double weekSalary):base(firstname, lastname)
        {
            this.WeekSalary = weekSalary;
        }

        public double WeekSalary { get; private set; }

        public double MoneyPerHour
        {
            get
            {
                return WeekSalary / (7 * 24);
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}: {2:F2}", this.FirstName, this.LastName, this.MoneyPerHour);
        }
    }
}
