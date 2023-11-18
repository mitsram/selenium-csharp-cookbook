using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TheInternet.Tests.Drivers;

public class Driver
{
    public static IWebDriver InitializeDriver()
    {   
        // If no env variable set, default is Chrome
        var factory = new DriverFactory(GetBrowserTypeFromEnv());
        return factory.CreateDriver();        
    }

    public static BrowserType GetBrowserTypeFromEnv()
    {
        string? envBrowserType = Environment.GetEnvironmentVariable("BROWSER_TYPE");
        string browserType = string.IsNullOrEmpty(envBrowserType) ? "Chrome" : envBrowserType;

        if (!Enum.TryParse(browserType, true, out BrowserType type))
            throw new ArgumentException($"Invalid browser type: {browserType}");
        return type;
    }
}