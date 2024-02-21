
using System.Text.RegularExpressions;
using SunmiPOSLib.Enum;

namespace SunmiPOSLib.Models
{

    public class CODABAR : BarcodeModel
    {
        public CODABAR() : base(6, "CODABAR", BarcodeFormat.Codabar)
        {
        }

        public override bool IsValid(string content)
        {
            if (!base.IsValid(content)) return false;
            Regex regex = new Regex(@"^[a-dA-D][0-9\-\$\/\+]+[a-dA-D]$");
            return regex.IsMatch(content);
        }
    }
}
