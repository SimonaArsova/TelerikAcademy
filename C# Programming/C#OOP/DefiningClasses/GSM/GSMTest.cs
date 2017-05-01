
using System;

namespace DefiningClasses
{
    class GSMTest
    {
        static void Main()
        {

            GSM[] gsm = new GSM[3];
            Battery bat = new Battery("1sd34",500,100,BatteryType.NiCd);
            Display disp = new Display();
            Battery anotherBat = new Battery(800, 200);
            Display anotherDisp = new Display(4.5, 20000000);
            gsm[0] = new GSM("IPhone 6S", "Apple", 1000.00, bat.ToString(), disp.ToString());
            gsm[1] = new GSM("Galaxy S5", "Samsung", 620.00, "Ivan", anotherBat.ToString(),disp.ToString());
            gsm[2] = new GSM("Nexus 5X", "LG", anotherBat.ToString(), anotherDisp.ToString());

            foreach (var phone in gsm)
            {
                Console.WriteLine(phone.ToString());
                Console.WriteLine();
            }

            Console.WriteLine("=========================");
            Console.WriteLine(GSM.IPhone4S);
            Console.WriteLine("=========================");

            GSMCallHistoryTest test = new GSMCallHistoryTest();
            test.Test();
        }

    }
}
