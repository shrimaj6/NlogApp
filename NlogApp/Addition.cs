using System;
using System.Collections.Generic;
using System.Text;

namespace NlogApp
{
    public class Addition
    {
        static Nlog nLog = new Nlog();
        public static void Add()
        {
            int firstNo, secondNo;
            Console.Write("Enter First Number : ");
            firstNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number : ");
            secondNo = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            if (firstNo == 0 || secondNo == 0)
            {
                nLog.LogDebug("Debug Successfully.");
                //nLog.LogError("First Number or Second Number is Zero.");
                //nLog.LogInfo("Add Method");
                Console.Write("0");
            }
            else
            {
                sum = firstNo + secondNo;
                //nLog.LogInfo("Addition method executed");
                nLog.LogDebug("Debug Successfully");
                //nLog.LogWarn("First Number and Second Number is not Zero.");
                Console.Write("Addition is : " + sum);
            }
        }
    }
}

