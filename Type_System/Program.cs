namespace Type_System
{
    // Make an object of that class whoese functionality you want to run and run that metod on the reference in which code is placed
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4] { 5, 4, 3, 1};
            var g = new Generics<int>(arr);
            Console.WriteLine(g.GiveCount());
            int[] sorted_arr = g.SortArr();
            Console.WriteLine(sorted_arr[0] + ", " +  sorted_arr[1] +", " + sorted_arr[2] + ", " + sorted_arr[3]);
        }
    }
}

