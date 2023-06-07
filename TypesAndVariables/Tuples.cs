using System;

namespace TypesAndVariables
{
    public class Tuples
    {
        public (string first_name, string last_name) Names()
        {
            string first_name = "Satyam";
            string last_name = "Awasthi";

            return (first_name, last_name);
        }
    }
}