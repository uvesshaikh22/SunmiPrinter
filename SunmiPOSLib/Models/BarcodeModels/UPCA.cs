

using SunmiPOSLib.Enum;

namespace SunmiPOSLib.Models
{
    public class UPCA : NumericalOnlyBarcodeModel
    {
        public UPCA() : base(0, "UPC-A", BarcodeFormat.UpcA)
        {
        }

        public override bool IsValid(string content)
        {
            return base.IsValid(content) && content.Length == 12;
        }
    }
}
