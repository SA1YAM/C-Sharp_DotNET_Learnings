using System;
using System.Linq.Expressions;

namespace Exceptionss
{
    public class DefExceptions
    {
        public int IndexInt(int[] array, int ind)
        {
            if (ind > array.Length - 1)
            {
                throw new InvalidIndexException("Index cannot be more than the range of array");
            }

            else if (ind < 0)
            {
                throw new InvalidIndexException("Index cannot be negative");
            }
            else 
            {
                return array[ind];
            }

        }
    
    }
}
