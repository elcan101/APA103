using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.Exception
{
    public class InvalidUsernameException : System.Exception
    {
        public InvalidUsernameException() : base("Username is invalid!") { }

        public InvalidUsernameException(string message) : base(message) { }
    }
}