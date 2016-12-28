namespace Homework
{
    using System;

    public class GSMCallHistoryTest
    {
        public static void Test()
        {
            int longestCall = 0;

            GSM myGSM = new GSM("One Plus", "X");
            myGSM.Owner = "me";

            myGSM.AddCall(new Call(new DateTime(2016, 6, 11, 13, 59, 0), "0888888888", 33));
            myGSM.AddCall(new Call(new DateTime(2016, 6, 11, 14, 22, 11), "0888888888", 55));
            myGSM.AddCall(new Call(new DateTime(2016, 6, 11, 15, 59, 0), "0888888888", 120));
            myGSM.AddCall(new Call(new DateTime(2016, 6, 11, 16, 59, 0), "088888888x", 6));

            Console.WriteLine("\n-----History of all calls-----");
            myGSM.PrintHistory();

            Console.WriteLine("\n-----Total price of all calls-----");
            int duration = 0;

            foreach (var call in myGSM.CallHistory)
            {
                duration += call.CallDuration;
            }

            Console.WriteLine("{0:F2}lv for {1} seconds",myGSM.TotalCallPrice(),duration); 

            foreach (var call in myGSM.CallHistory)
            {
                if (longestCall <= call.CallDuration)
                {
                    longestCall = call.CallDuration;
                }
            }

            foreach (var call in myGSM.CallHistory)
            {
                if (longestCall==call.CallDuration)
                {
                    myGSM.DeleteCall(call);
                    break;//delete only the first if there are multiple longest calls with the same call duration
                }
            }

            Console.WriteLine("\n-----Longest call deleted-----");
            myGSM.PrintHistory();

            Console.WriteLine("\n-----Phone history deleted-----");
            myGSM.ClearHistory();
            myGSM.PrintHistory();
        }
    }
}
