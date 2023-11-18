using OpenQA.Selenium;

namespace TheInternet.Tests.Pages;

public class BasePage 
{
    protected IWebDriver driver;

    public BasePage(IWebDriver driver)
    {
        this.driver = driver;
    }

}