using System;
using System.Collections.Generic;
using System.Text;

namespace SunmiPOSLib.Exceptions
{
    public class PrintTableException : Exception
    {
        public PrintTableException() : base("Error printing form.") { }
    }
}
