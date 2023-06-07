using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Techniques
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Person(string fname, string mname, string lname)
        {
            FirstName = fname;
            MiddleName = mname;
            LastName = lname;
        }

        public void Deconstruct(out string fname, out string lname)
        {
            fname = FirstName;
            lname = LastName;
        }

        public void Deconstruct(out string fname, out string mname, out string lname)
        {
            fname = FirstName;
            mname = MiddleName;
            lname = LastName;
        }

        public void Deconstruct(out string fname)
        {
            fname = FirstName;
        }

    }

    public class Deconstruction
    {
        public void RunDeconstruct()
        {
            var (fName, lName) = new Person("Robert", "Downy", "junior");

        //    var (fName, lName) = p;
            Console.WriteLine($"Hello {fName} {lName}");
        }
    }
}
