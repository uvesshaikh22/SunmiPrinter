using System;
//using CommunityToolkit.Maui;
using SunmiPOSLib.Services;
namespace SunmiPOSLib;

/// <summary>
/// This class adds biometric authentication support to the Maui application.
/// </summary>
public static class MauiAppBuilderExtensions
{
    /// <summary>
    /// Adds biometric authentication support to the Maui application.
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    public static MauiAppBuilder UseSunmiPrinter(
        this MauiAppBuilder builder)
    {
        builder = builder ?? throw new ArgumentNullException(nameof(builder));
       // builder.UseMauiCommunityToolkit();
        builder.Services.AddSingleton(static _ => SunmiPrinter.Current);

        return builder;
    }
}

