using System;
using System.Collections.Generic;
using System.Text;

namespace SunmiPOSLib.Exceptions
{
    public class AdvancePaperException : Exception
    {
        public AdvancePaperException() : base("Error advancing paper.") { }
    }
}
