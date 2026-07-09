using System;

namespace Exp
{
    class FileOperationException : Exception
    {
        public FileOperationException(string message) : base(message)
        {
        }
    }
}