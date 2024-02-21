using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Hosting;

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
        builder.Services.AddSingleton(static _ => SunmiPrinter.Current);

        return builder;
    }
}

