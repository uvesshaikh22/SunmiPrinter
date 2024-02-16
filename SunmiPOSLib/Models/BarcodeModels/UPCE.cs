using ZXing;

namespace SunmiPOSLib.Models
{
    public class UPCE : NumericalOnlyBarcodeModel
    {
        public UPCE() : base(1, "UPC-E", BarcodeFormat.UPC_E)
        {
        }

        public override bool IsValid(string content)
        {
            return base.IsValid(content) && content.Length == 6;
        }
    }
}
