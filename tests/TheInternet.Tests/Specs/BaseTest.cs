using NUnit.Framework;
using OpenQA.Selenium;

namespace TheInternet.Tests.Specs;

[TestFixture]
public class BaseTest
{
    IWebDriver? driver;

    [SetUp]
    public void Setup()
    {
        driver = DriverFactory.InitializeDriver();
        driver.Navigate().GoToUrl("");
    }
}