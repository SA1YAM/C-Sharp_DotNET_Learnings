using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcepts
{
    internal class CreateIndexer
    {
        private string[] val = new string[3];

        public string this[int index]
        {

            get
            {

                return val[index];
            }


            set
            {
                val[index] = value;
            }
        }

    }
}
