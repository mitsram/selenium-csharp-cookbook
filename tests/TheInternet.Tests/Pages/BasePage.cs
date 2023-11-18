using OpenQA.Selenium;

namespace TheInternet.Tests.Pages;

public class BasePage 
{
    protected IWebDriver? _driver;

    public BasePage(IWebDriver driver)
    {
        _driver = driver;
    }

}