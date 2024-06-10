using System;

namespace GeniyIdiotConsoleApp.Exceptions
{
    public class ReturnException : Exception
    {
        public ReturnException()
        { }
        public ReturnException(string message) : base(message)
        { }
    }
}
