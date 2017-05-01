using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    class GSMCallHistoryTest
    {
        public void Test()
        {
            Battery bat = new Battery("1sd34", 500, 100, BatteryType.NiCd);
            Display disp = new Display();
            GSM phone = new GSM("6", "IPhone", bat.ToString(), disp.ToString());

            phone.AddCall("12.12.2012", "15:00", "+359 885 635338", 500);
            phone.AddCall("04.04.2004", "12:00", "+359 885 643453", 200);
            phone.AddCall("01.03.2014", "09:00", "+359 884 654634", 100);

            foreach (var item in GSM.CallList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Total price of all calls in history: " + phone.CalculateCallPrice(0.37) + "BGN");


            Console.WriteLine("=========================");
            phone.DeleteCall();

            foreach (var item in GSM.CallList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Total price of all calls in history: " + phone.CalculateCallPrice(0.37) + "BGN");

            Console.WriteLine("=========================");
            phone.ClearHistory();

            foreach (var item in GSM.CallList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
