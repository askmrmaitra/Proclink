using System;
using System.Collections.Generic;
using System.Text;

namespace exp
{
    class InvalidMarksException : Exception
    {
        public InvalidMarksException(string message) : base(message)
        {
        }
    }
}
