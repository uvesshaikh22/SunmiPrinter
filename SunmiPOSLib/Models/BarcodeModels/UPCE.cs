

using SunmiPOSLib.Enum;

namespace SunmiPOSLib.Models
{
    public class UPCE : NumericalOnlyBarcodeModel
    {
        public UPCE() : base(1, "UPC-E", BarcodeFormat.UpcE)
        {
        }

        public override bool IsValid(string content)
        {
            return base.IsValid(content) && content.Length == 6;
        }
    }
}
