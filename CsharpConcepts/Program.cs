namespace CsharpConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CreateIndexer ic = new CreateIndexer();

            ic[0] = "C";
            ic[1] = "CPP";
            ic[2] = "CSHARP";

            Console.Write("Printing values stored in objects used as arrays\n");

            Console.WriteLine("First value = {0}", ic[0]);
            Console.WriteLine("Second value = {0}", ic[1]);
            Console.WriteLine("Third value = {0}", ic[2]);


            Iterate days = new Iterate();

            foreach (string day in days)
            {
                Console.Write(day + " ");
            }
            // Output: Sun Mon Tue Wed Thu Fri Sat
            Console.ReadKey();
        }
    }
}