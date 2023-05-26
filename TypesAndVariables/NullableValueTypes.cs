using System;


namespace TypesAndVariables
{
    // A nullable value type T? represents all values of its underlying value type T and an additional null value.
    public class NullableValueTypes
    {
        public static void RunNullableValueTypes() 
        {
            int? a = 28;
            int b = a ?? -1;
            Console.WriteLine($"b is {b}");  // output: b is 28

            int? c = null;
            int d = c ?? -1;
            Console.WriteLine($"d is {d}");  // output: d is -1

            Console.WriteLine(a.GetType());
            Console.WriteLine(c.GetType());
        }
    }
}
