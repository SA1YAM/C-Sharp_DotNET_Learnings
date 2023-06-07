using System;
using System.Collections.Generic;

namespace TypesAndVariables
{
    public class Class : IInterface
    {
        public string Name { get; set; }
        public string Type { get; }
        public Class(string name)
        {
            Name = name;
            Type = "Class";
        }

        public int GiveMax(int no_1, int no_2)
        {
            if (no_1 == no_2)
            {
                return 0;
            }
            else if (no_1 > no_2)
            {
                return no_1;
            }
            else
            {
                return no_2;
            }

        }
    }
}