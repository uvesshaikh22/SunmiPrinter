using System;
using System.Collections.Generic;
using System.Text;

namespace SunmiPOSLib.Models
{
    public class PrinterInfo
    {
        public string SerialNo { get; set; }
        public string DeviceModel { get; set; }
        public string FirmwareVersion { get; set; }
        public string PrintedDistance { get; set; }
        public string Paper { get; set; }

        public PrinterInfo(string serialNo, string deviceModel, string firmwareVersion, string printedDistance, string paper)
        {
            SerialNo = serialNo;
            DeviceModel = deviceModel;
            FirmwareVersion = firmwareVersion;
            PrintedDistance = printedDistance;
            Paper = paper;
        }
    }
}
