using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class DriverFactory
{
    public static IWebDriver InitializeDriver()
    {
        return new ChromeDriver();
    }
}