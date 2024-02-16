using System;
using System.Collections.Generic;
using System.Text;

namespace SunmiPOSLib.Exceptions
{
    public class PrinterConnectionException : Exception
    {
        public PrinterConnectionException() : base("Unable to connect to printer.") { }
    }
}
