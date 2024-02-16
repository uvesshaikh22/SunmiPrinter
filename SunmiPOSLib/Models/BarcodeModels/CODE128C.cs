using ZXing;

namespace SunmiPOSLib.Models
{
    public class CODE128C : BarcodeModel
    {
        public CODE128C() : base(10,"CODE128C", BarcodeFormat.CODE_128)
        {
        }
    }
}
