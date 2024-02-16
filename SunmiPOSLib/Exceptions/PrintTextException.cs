using System;
using System.Collections.Generic;
using System.Text;

namespace SunmiPOSLib.Exceptions
{
    public class PrintTextException : Exception
    {
        public PrintTextException() : base("Error printing text.") { }
    }
}
