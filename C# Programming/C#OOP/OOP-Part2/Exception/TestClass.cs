using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class TestClass
    {
        int numberOfSth;
        DateTime date;

        public TestClass(int number, DateTime date)
        {
            this.NumberOfSth = number;
            this.Date = date;
        }

        public int NumberOfSth
        {
            get
            {
                return this.numberOfSth;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    throw new InvalidRangeException<int>(0, 100, "Value can't be between 1 and 100");
                }
                this.numberOfSth = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                if (value > ConvertStringToDate("12.31.2013") || value < ConvertStringToDate("01.01.1980"))
                {
                    throw new InvalidRangeException<DateTime>(ConvertStringToDate("01.01.1980"), ConvertStringToDate("12.31.2013"), "Invalid date");
                }
                this.date = value;
            }
        }

        public static DateTime ConvertStringToDate(string text)
        {
            string stringFormat = "MM.dd.yyyy";
            DateTime birthDate = DateTime.ParseExact(text, stringFormat, CultureInfo.InvariantCulture);

            return birthDate;
        }
    }
}
