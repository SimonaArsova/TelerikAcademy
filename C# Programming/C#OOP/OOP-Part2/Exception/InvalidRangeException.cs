using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(T start, T end, string message) : base(message)
        {
            this.Start = start;
            this.End = end;
        }
        
        public T Start { get; private set; }
        public T End { get; private set; }
    }
}
