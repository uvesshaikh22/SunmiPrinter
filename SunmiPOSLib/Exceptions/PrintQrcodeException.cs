using System;
using System.Collections.Generic;
using System.Text;

namespace SunmiPOSLib.Exceptions
{
    public class PrintQrcodeException : Exception
    {
        public PrintQrcodeException() : base("Error in barcode printing.") { }
    }
}
