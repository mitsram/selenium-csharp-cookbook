using NUnit.Framework;
using OpenQA.Selenium;

namespace TheInternet.Tests.Specs;

public class BaseTest
{
    protected IWebDriver? driver;

    [SetUp]
    public void Setup()
    {
        driver = DriverFactory.InitializeDriver();        
    }

    [TearDown]
    public void Teardown()
    {
        driver!.Quit();
    }
}