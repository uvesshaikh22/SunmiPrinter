using System;
using System.Collections.Generic;
using System.Text;
using SunmiPOSLib.Enum;

namespace SunmiPOSLib.Models
{
    public class ITF : NumericalOnlyBarcodeModel
    {
        public ITF() : base(5, "ITF", BarcodeFormat.Itf)
        {
        }
    }
}
