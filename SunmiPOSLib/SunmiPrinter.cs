using System;
using SunmiPOSLib.Services;
namespace SunmiPOSLib;

/// <summary>
/// This class provides access to the biometric authentication implementation.
/// </summary>
public static class SunmiPrinter
{
    private static Lazy<IPrinterConnection> _implementation = new(() =>
    {
#if __IOS__
        return new PrinterConnection();
#elif __ANDROID__
        return new PrinterConnection();
#elif WINDOWS
        return new PrinterConnection();
#else
        return new PrinterConnection();
#endif
    });

    /// <summary>
    /// Current biometric authentication implementation to use.
    /// </summary>
    public static IPrinterConnection Current
    {
        get => _implementation.Value;
        set => _implementation = new Lazy<IPrinterConnection>(() => value);
    }
}


