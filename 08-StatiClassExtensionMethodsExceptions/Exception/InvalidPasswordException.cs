using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.Exception
{
    internal class InvalidPasswordException : SystemException
    {
            public InvalidPasswordException() : base("Password is invalid!") { }

            public InvalidPasswordException(string message) : base(message) { }
        }
    
}
