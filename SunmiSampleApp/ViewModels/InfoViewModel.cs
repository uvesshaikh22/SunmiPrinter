using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SunmiPOSLib;
using SunmiPOSLib.Models;
namespace SunmiSampleApp.ViewModels
{
    internal class InfoViewModel : INotifyPropertyChanged
    {
        PrinterInfo printerInfo;
        PackageInfo packageInfo;

        public event PropertyChangedEventHandler PropertyChanged;

        public InfoViewModel()
        {
            // Carregar dados da impressora atualmente conectada
            LoadPrinterInfo();

            // Carregar dados da dependência da Sunmi
            LoadPackageInfo();
        }

        /// <summary>
        /// Asynchronously loads all printer data and instantiates a new PrinterInfo model object, 
        /// firing a PropertyChanged event to update the view.
        /// </summary>
        public async void LoadPrinterInfo()
        {
            var SerialNo = SunmiPrinter.Current.GetPrinterSerialNo();
            var DeviceModel = SunmiPrinter.Current.GetPrinterModel();
            var FirmwareVersion = SunmiPrinter.Current.GetFirmwareVersion().Trim();
            var PrintedDistance = await SunmiPrinter.Current.GetPrintedLength() + "mm";
            var Paper = SunmiPrinter.Current.GetPrinterPaper() == 1 ? "58mm" : "80mm";
            PrinterInfo = new PrinterInfo(SerialNo, DeviceModel, FirmwareVersion, PrintedDistance, Paper);
        }

        /// <summary>
        /// Synchronously loads all package data and instantiates a new PackageInfo model object,
        /// firing a PropertyChanged event to update the view.
        /// </summary>
        public void LoadPackageInfo()
        {
            var versionName = SunmiPrinter.Current.GetServiceVersionName();
            var versionCode = SunmiPrinter.Current.GetServiceVersionCode();
            PackageInfo = new PackageInfo(versionName, versionCode);
        }

        /// <summary>
        /// Helper method to fire PropertyChange events on class member setter methods.
        /// </summary>
        /// <param name="propertyName">String representation of the property being set.</param>
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public PrinterInfo PrinterInfo
        {
            get { return printerInfo; }
            set
            {
                printerInfo = value;
                OnPropertyChanged();
            }
        }
        public PackageInfo PackageInfo
        {
            get { return packageInfo; }
            set
            {
                packageInfo = value;
                OnPropertyChanged();
            }
        }
    }
}

