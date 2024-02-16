using System;
using System.Collections.Generic;
using System.Text;

namespace SunmiPOSLib.Exceptions
{
    public class BarcodeValidationException : Exception
    {
        public BarcodeValidationException() : base("Invalid Barcode.") { }
    }
}
