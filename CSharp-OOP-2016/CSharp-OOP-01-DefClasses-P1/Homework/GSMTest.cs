namespace Homework
{
    using System;

    public class GSMTest
    {
        static void Main(string[] args)
        {
            GSM myGSM = new GSM("One Plus", "X");
            myGSM.Battery = new Battery("non-removable", 2525, BatteryType.LiPo);
            myGSM.Owner = "me";
            //Console.WriteLine(myGSM.ToString());
            //Console.WriteLine(GSM.IPhone4s);
            GSM iPhone6 = new GSM("Apple", "Iphone6");
            GSM samsungS7 = new GSM("Samsung", "S7");

            GSM[] allGSMs = new GSM[] {myGSM,GSM.IPhone4s, iPhone6, samsungS7 };
            foreach (var gsm in allGSMs)
            {
                Console.WriteLine(gsm);
            }

            Console.WriteLine("\n-----Call history test-----");
            GSMCallHistoryTest.Test();

        }
    }
}
