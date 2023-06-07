namespace Exceptionss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new DefExceptions();
            int[] intarr = new int[] { 11, 12, 13, 14, 15 };

            string block = "complete try block";
            try
            {
                int val = d.IndexInt(intarr, -2);
            }
            catch (InvalidIndexException e)
            {
                block = "exception caught, catch block";
                Console.WriteLine("Specific Exception catched" + e.StackTrace);
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine(block + " has been executed");
            }
        }
    }
}