using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SunmiPOSLib.Models;
using Image = SunmiPOSLib.Models.Image;

namespace SunmiPOSLib.Services
{
    public interface IPrinterConnection
    {

        /// <summary>
        /// Send ESC/POS commands to print.
        /// </summary>
        void SendRawData(byte[] data);

        /// <summary>
        /// Send ESC/POS commands to init a connection with a printer.
        /// </summary>
        bool InitConnection();

        /// <summary>
        /// Send ESC/POS commands to close a connection with a printer.
        /// </summary>
        bool CloseConnection();

        /// <summary>
        /// Get status of printer connection.
        /// </summary>
        bool IsConnected();

        /// <summary>
        /// Send ESC/POS for the printer to print a barcode.
        /// </summary>
        bool PrintBarcode(Barcode barcode);

        /// <summary>
        /// Send ESC/POS for the printer to print a qrcode.
        /// </summary>
        bool PrintQRCode(QRcode qrcode);

        /// <summary>
        /// Send ESC/POS for the printer to print text.
        /// </summary>
        bool PrintText(Text text);

        /// <summary>
        /// Send ESC/POS for the printer to print an image.
        /// </summary>
        bool PrintImage(Image image);


        /// <summary>
        /// Get the serial number from the connected printer.
        /// </summary>
        bool AdvancePaper();

        /// <summary>
        /// Send ESC/POS for the printer to print a table.
        /// </summary>
        bool PrintTable(Table table);

        /// <summary>
        /// Send ESC/POS for the printer to print a invoices.
        /// </summary>
        bool PrintInvoices(List<Invoice> invoices);
        /// <summary>
        /// Sends ESC/POS commands to the printer for printing invoices with QR codes.
        /// </summary>
        /// <param name="invoices">The list of invoices with QR codes to be printed.</param>
        /// <returns>True if the printing process is successful; otherwise, false.</returns>
        bool PrintInvoicesWithQR(List<InvoiceWithQR> invoices);


        string GetPrinterSerialNo();

        /// <summary>
        /// Get the printer model from the connected printer.
        /// </summary>
        string GetPrinterModel();

        /// <summary>
        /// Get the firmware version from the connected printer.
        /// </summary>
        string GetFirmwareVersion();

        /// <summary>
        /// Get the service version from the connected printer.
        /// </summary>
        string GetServiceVersion();

        /// <summary>
        /// Get the sheet size from the connected printer.
        /// </summary>
        int GetPrinterPaper();

        /// <summary>
        /// Get the length of the printed paper from the connected printer.
        /// </summary>
        Task<string> GetPrintedLength();

        /// <summary>
        /// Get the service version name from the application context.
        /// </summary>
        string GetServiceVersionName();

        /// <summary>
        /// Get the service version code from the application context.
        /// </summary>
        string GetServiceVersionCode();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string ShowPrinterStatus();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text">Invoice</param>
        /// <param name="qrCode">QR Code</param>
        /// <returns></returns>
        bool PrintReceiptWithQR(Text text, QRcode qrCode);
    }
}
