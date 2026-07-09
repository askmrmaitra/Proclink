using System;

namespace Exp
{
    class InvalidRatingException : Exception
    {
        public InvalidRatingException(string message) : base(message)
        {
        }
    }
}