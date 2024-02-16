using System;
using System.Collections.Generic;
using System.Text;

namespace SunmiPOSLib.Models
{
    public class PackageInfo
    {
        public string versionName { get; set; }
        public string versionCode { get; set; }

        public PackageInfo(string versionName, string versionCode)
        {
            this.versionName = versionName;
            this.versionCode = versionCode;
        }
    }
}
