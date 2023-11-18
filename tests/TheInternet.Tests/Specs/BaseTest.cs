using NUnit.Framework;
using OpenQA.Selenium;
using TheInternet.Tests.Drivers;

namespace TheInternet.Tests.Specs;

public class BaseTest
{
    protected IWebDriver? driver;

    [SetUp]
    public void Setup()
    {
        driver = Driver.InitializeDriver();        
    }

    [TearDown]
    public void Teardown()
    {
        driver!.Quit();
    }
}