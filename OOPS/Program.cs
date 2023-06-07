namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Lion());
            
            foreach (var animal in animals)
            {
                animal.Sound();
            }

        }
    }
}