using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;

namespace TheInternet.Tests.Drivers;

public class DriverFactory
{
    private readonly BrowserType _browserType;
    
    public DriverFactory(BrowserType browserType)
    {
        _browserType = browserType;
    }

    public IWebDriver CreateDriver()
    {
        return _browserType switch
        {
            BrowserType.Chrome => new ChromeDriver(),
            BrowserType.Safari => new SafariDriver(),
            BrowserType.Firefox => new FirefoxDriver(),
            _ => throw new ArgumentException("Invalid browser type"),
        };
    }
}

public enum BrowserType
{
    Chrome,
    Firefox,
    Safari
}