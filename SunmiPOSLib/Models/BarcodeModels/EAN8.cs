using System;
using System.Collections.Generic;
using System.Text;
using SunmiPOSLib.Enum;

namespace SunmiPOSLib.Models
{
    public class EAN8 : NumericalOnlyBarcodeModel
    {
        public EAN8() : base(3, "EAN8", BarcodeFormat.Ean8)
        {
        }

        public override bool IsValid(string content)
        {
            return base.IsValid(content) && content.Length == 8;
        }
    }
}
