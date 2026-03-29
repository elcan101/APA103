using _08_StatiClassExtensionMethodsExceptions.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.Exception
{
    internal class AccountLockedException: SystemException
{
    public AccountLockedException() : base("Account is locked!") { }
    }
     
}
