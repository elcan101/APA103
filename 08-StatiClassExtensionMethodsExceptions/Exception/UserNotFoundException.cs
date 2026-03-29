using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.Exception
{
    internal class UserNotFoundException : SystemException
    {
        public UserNotFoundException() : base("User not found!") { }

        public UserNotFoundException(string username)
            : base($"User '{username}' not found!")
        {
        }
    }
}
