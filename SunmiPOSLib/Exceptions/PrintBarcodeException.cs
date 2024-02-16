using System;
using System.Collections.Generic;
using System.Text;

namespace SunmiPOSLib.Exceptions
{
    public class PrintBarcodeException : Exception
    {
        public PrintBarcodeException() : base("Barcode printing error.") { }
    }
}
