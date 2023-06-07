using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionss
{
    public class InvalidIndexException : Exception
    {
        public InvalidIndexException() : base() { }
        public InvalidIndexException(string message) : base(message) { }
        public InvalidIndexException(string message, Exception inner) : base(message, inner) { }
    }
}
