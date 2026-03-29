using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.Exception
{
    internal class IncorrectPasswordException : SystemException
{
    public int AttemptsLeft { get; set; }

        public IncorrectPasswordException(int attemptsLeft)
            : base($"Incorrect password! Attempts left: {attemptsLeft}")
        {
            AttemptsLeft = attemptsLeft;
        }
    }
}
