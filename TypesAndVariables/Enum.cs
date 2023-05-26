using System;

namespace TypesAndVariables
{
  // An enumeration type (or enum type) is a value type defined by a set of named constants of the underlying integral numeric type.
    public class Enum
    {
        public enum Planets
        {
            Mercury = 2440,
            Venus = 6052,
            Earth = 6371,
            Mars = 2106,
            Jupiter = 69911,
            Saturn = 58232,
            Uranus = 25362,
            Neptune = 24622
        }

        public void RunEnum()
        {
            Planets planet = Planets.Mercury;
            Console.WriteLine($"The radius of {planet} is {(int)planet}");

            var a = (Planets)2106;
            Console.WriteLine(a);

        }

    }
}
