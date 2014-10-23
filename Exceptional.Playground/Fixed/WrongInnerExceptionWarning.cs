﻿using System.Diagnostics;
using System.Security;

namespace Exceptional.Playground.Issues
{
    class WrongInnerExceptionWarning
    {
        /// <exception cref="SecurityException">Condition. </exception>
        public void Foo()
        {
            try
            {
                throw new SecurityException();
            }
            catch (SecurityException exception)
            {
                Debug.WriteLine(exception.Message);
                throw exception; // No warning: No new exception without inner exception is constructed
            }
        }
    }
}
