using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = TestClass.ConvertStringToDate("05.02.2010");
            TestClass numberTest = new TestClass(50, date);
            Console.WriteLine(numberTest);

        }
    }
}
