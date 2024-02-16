using System;
using System.Collections.Generic;
using System.Text;

namespace SunmiPOSLib.Exceptions
{
    public class QrcodeValidationException : Exception
    {
        public QrcodeValidationException() : base("Invalid QRcode.") { }
    }
}
