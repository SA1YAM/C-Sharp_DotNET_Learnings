using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_System
{
    public class Generics<T>
    {
        public T[] Arr { get; set; }
        public Generics(T[] arr_) 
        {
            Arr = arr_;
        }

        public int GiveCount() 
        {
            return Arr.Length;
        }

        public T[] SortArr() 
        {
            Array.Sort(Arr);
            return Arr;
        }
    }
}
