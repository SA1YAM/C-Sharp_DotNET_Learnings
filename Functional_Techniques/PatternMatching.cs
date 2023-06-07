using System;
using System.Collections.Generic;

namespace Functional_Techniques
{
    public class PatternMatching
    {
        public static void IsaNo()
        {
            int? num = 15;

            if (num is int number)
            {
                Console.WriteLine($"The nullable int 'num' has the value {number}");
            }
            else
            {
                Console.WriteLine("The nullable int 'num' doesn't hold a value");
            }
        }
        public static string PerformDiscreteOp(int num) =>
           num switch
           {
               1 => "this is no. 1",
               2 => "this is no. 2",
               _ => "this is some other no",
           };

    }
}
