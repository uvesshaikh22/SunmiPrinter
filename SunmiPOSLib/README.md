
# MauiSunmiPrint Library

MauiSunmiPrint is a lightweight Android library designed for Maui applications, simplifying the integration of customizable receipt and invoice printing on Sunmi Smart Mobile Terminals.

## Getting Started

follow the steps below:

### ⏳ Installation

Use this **Quickstart** command to install in your project :

- (Use **nuget** package manager to install (recommended))

```bash
Install-Package SunmiPOSLib
```

**or**

1. Add the SunmiPrint NuGet package to your Maui project by adding the following line to your .csproj file:

   ```xml
   <ItemGroup>
       <PackageReference Include="MauiSunmiPrint" Version="1.0.0" />
   </ItemGroup>


This command install SunmiPOSLib with your project.

Enjoy 🎉

## Usage
```csharp
var builder = MauiApp.CreateBuilder();
builder
    .UseMauiApp<App>()
    .UseSunmiPrinter()  <!-- Add this line -->
    .ConfigureFonts(fonts =>
    {
        fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
        fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
    });
builder.Services.AddSingleton(SunmiPrinter.Current);  <!-- Add this line to initialize printer connection -->
```

### ❤️ Example Using C#

Import SunmiPOSLib Printer Class:

```csharp
using using SunmiPOSLib;
using SunmiPOSLib.Models;
```

In-Built Printer Selection:
Your in-built printer will be automatically selected for printing with SunmiPrint.

**BarCode Print**:

```csharp
Barcode barcode = new Barcode("266565256123");
SunmiPrinter.Current.PrintBarcode(barcode);
```

**Print QRCode**:

```csharp
 QRcode qRcode = new QRcode("TestQR");
 bool wasSuccessful = SunmiPrinter.Current.PrintQRCode(qRcode);
```

**Print Table Format**:

```csharp
 List<Table> tables = new List<Table>();
        for (int i = 0; i < 3; i++)
        {
            // Replace dynamic values with static ones
            var content1 = "Value1";
            var content2 = "Value2";
            var content3 = "Value3";

            var contents = new string[] { content1, content2, content3 };

            var width1 = 20; // Replace with your desired static width
            var width2 = 30; // Replace with your desired static width
            var width3 = 25; // Replace with your desired static width

            var widths = new int[] { width1, width2, width3 };

            var align1 = AlignmentEnum.LEFT;    // Replace with your desired static alignment
            var align2 = AlignmentEnum.CENTER;  // Replace with your desired static alignment
            var align3 = AlignmentEnum.RIGHT;   // Replace with your desired static alignment

            var alignments = new AlignmentEnum[] { align1, align2, align3 };
            tables.Add(new Table(contents, widths, alignments));
        }
         foreach (var table in tables)
        {
            try
            {
                
                var wasSucessful = SunmiPrinter.Current.PrintTable(table);
            }
            catch (Exception exception)
            {
                await DisplayAlert("Error", exception.Message, "ok");
                break;
            }

        }
```

**Open Drawer**:

```csharp
 //You can change text size and bold as per your need.
 Text text = new Text("欢迎光临(Simplified Chinese) 歡迎光臨（traditional chinese） Welcome(English) 어서 오세요.(Korean) いらっしゃいませ(Japanese) Willkommen in der(Germany) Souhaits de bienvenue(France) ยินดีต้อนรับสู่(Thai) Добро пожаловать(Russian) Benvenuti a(Italian) vítejte v(Czech) BEM - vindo Ao Brasil(Portutuese) مرحبا بكم في(Arabic)");
 bool wasSucessful = SunmiPOSLib.SunmiPrinter.Current.PrintText(text);
```

**Different Types of Printer Infomation**:

```csharp
// Retrieve the serial number of the connected Sunmi printer.
var SerialNo = SunmiPrinter.Current.GetPrinterSerialNo();

// Retrieve the model of the connected Sunmi printer.
var DeviceModel = SunmiPrinter.Current.GetPrinterModel();

// Retrieve the firmware version of the connected Sunmi printer and trim any extra whitespace.
var FirmwareVersion = SunmiPrinter.Current.GetFirmwareVersion().Trim();

// Retrieve the printed distance of the Sunmi printer and format it as a string with "mm" unit.
var PrintedDistance = await SunmiPrinter.Current.GetPrintedLength() + "mm";

// Retrieve the type of paper loaded in the Sunmi printer and assign "58mm" or "80mm" accordingly.
var Paper = SunmiPrinter.Current.GetPrinterPaper() == 1 ? "58mm" : "80mm";

// Create a new instance of PrinterInfo with the retrieved printer details.
PrinterInfo = new PrinterInfo(SerialNo, DeviceModel, FirmwareVersion, PrintedDistance, Paper);

// Retrieve the version name of the Sunmi printer service.
var versionName = SunmiPrinter.Current.GetServiceVersionName();

// Retrieve the version code of the Sunmi printer service.
var versionCode = SunmiPrinter.Current.GetServiceVersionCode();

// Create a new instance of PackageInfo with the retrieved service version details.
PackageInfo = new PackageInfo(versionName, versionCode);
```

## 🚀 Features

- **In-Built Printer Selection:** Automatic in-built printer selection for hassle-free printing.
- **BarCode Print:** Effortlessly print Code128, Code39, and Ean13 barcodes.
- **Print QRCode:** Print 2D barcodes (QrCode) with ease.
- **Print Table Format:** Create and print tables with customizable content, widths, and alignments.
- **Open Drawer:** Trigger the opening of the drawer with a simple command.
- **Different Types of Printer Information:** Retrieve details like serial number, model, firmware version, printed distance, and paper type.

### 🖐 Requirements

**Supported operating systems**:

- Ubuntu 18.04
- Mac O/S
- Windows 10

(Please note that SunmiPrinter may work on other operating systems, but these are not tested nor officially supported at this time.)

**Dependencies:**

- .NET >7.0
- ZXing.net (>= 0.16.9)

**Stay up-to-date with the latest MauiSunmiPrint version for optimal project support. Currently in active development, frequent releases address issues and introduce enhancements. Your feedback is valuable—report any opportunities for improvement or issues you encounter**.

## 🧑‍🤝‍🧑 Contributing

We welcome open an issue if you have any trouble.
