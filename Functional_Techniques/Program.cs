namespace Functional_Techniques
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new Deconstruction();
            d.RunDeconstruct();

            PatternMatching.IsaNo();
            Console.WriteLine(PatternMatching.PerformDiscreteOp(2));
        }
    }
}