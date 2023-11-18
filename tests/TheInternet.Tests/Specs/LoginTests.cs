using System;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using TheInternet.Tests.Pages;

namespace TheInternet.Tests.Specs;

public class LoginTests : BaseTest
{    
    [Test]
    public void ReturnsSuccessful_When_Credentials_AreValid()
    {        
        driver!.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

        LoginPage loginPage = new(driver);
        loginPage.Login("tomsmith", "SuperSecretPassword!");

        bool isLoggedIn = loginPage.IsLoggedIn();
        isLoggedIn.Should().BeTrue();
    }

}