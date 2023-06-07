using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_System
{
    public class Anonymous
    {
        public void RunAnonymous() 
        {
            var v = new { first_name = "ABC", second_name = "DEF" };
            Console.WriteLine(v.first_name + v.second_name);

            var x = v with { second_name = "GHI" };
            Console.WriteLine(x);
        }
    }
}
