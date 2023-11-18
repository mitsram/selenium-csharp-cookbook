using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TheInternet.Tests.Drivers;

public class Driver
{
    public static IWebDriver InitializeDriver()
    {
        // TODO: Make browser type configurable ie. environment variables
        var factory = new DriverFactory(BrowserType.Chrome);
        return factory.CreateDriver();        
    }
}