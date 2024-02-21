using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SunmiPOSLib.Models;
using SunmiPOSLib.Services;

namespace SunmiPOSLib;

public class PrinterConnection : IPrinterConnection
{
    public bool AdvancePaper()
    {
        throw new NotImplementedException();
    }

    public bool CloseConnection()
    {
        throw new NotImplementedException();
    }

    public string GetFirmwareVersion()
    {
        throw new NotImplementedException();
    }

    public Task<string> GetPrintedLength()
    {
        throw new NotImplementedException();
    }

    public string GetPrinterModel()
    {
        throw new NotImplementedException();
    }

    public int GetPrinterPaper()
    {
        throw new NotImplementedException();
    }

    public string GetPrinterSerialNo()
    {
        throw new NotImplementedException();
    }

    public string GetServiceVersion()
    {
        throw new NotImplementedException();
    }

    public string GetServiceVersionCode()
    {
        throw new NotImplementedException();
    }

    public string GetServiceVersionName()
    {
        throw new NotImplementedException();
    }

    public bool InitConnection()
    {
        throw new NotImplementedException();
    }

    public bool IsConnected()
    {
        throw new NotImplementedException();
    }

    public bool PrintBarcode(Barcode barcode)
    {
        throw new NotImplementedException();
    }

    public bool PrintImage(SunmiPOSLib.Models.Image image)
    {
        throw new NotImplementedException();
    }

    public bool PrintInvoices(List<Invoice> invoices)
    {
        throw new NotImplementedException();
    }

    public bool PrintInvoicesWithQR(List<InvoiceWithQR> invoices)
    {
        throw new NotImplementedException();
    }

    public bool PrintQRCode(QRcode qrcode)
    {
        throw new NotImplementedException();
    }

    public bool PrintReceiptWithQR(Text text, QRcode qrCode)
    {
        throw new NotImplementedException();
    }

    public bool PrintTable(Table table)
    {
        throw new NotImplementedException();
    }

    public bool PrintText(Text text)
    {
        throw new NotImplementedException();
    }

    public void SendRawData(byte[] data)
    {
        throw new NotImplementedException();
    }

    public string ShowPrinterStatus()
    {
        throw new NotImplementedException();
    }
}

