using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcepts
{
    public class Iterate : IEnumerable
    {
        private string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < days.Length; index++)
            {
                // Yield each day of the week.
                yield return days[index];
            }
        }
    }
}
