using System;

namespace DATA.Errors
{
    public class EmptyCollectionException : Exception
    {
        public EmptyCollectionException(string message) : base(message)
        {
        }
    }
}
