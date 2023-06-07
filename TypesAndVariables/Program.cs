namespace TypesAndVariables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Struct s = new Struct();
            Enum e = new Enum();
            s.RunStruct();
            e.RunEnum();
        }
    }
}