using FluentAssertions;
using NUnit.Framework;
using TheInternet.Tests.Pages;

namespace TheInternet.Tests.Specs;

public class LoginTests : BaseTest
{    
    LoginPage? loginPage; 

    [SetUp]
    public new void Setup()
    {
        driver!.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
        loginPage = new(driver!);
    }

    [Test]
    public void ReturnsSuccessful_When_Credentials_AreValid()
    {        
        loginPage!.Login("tomsmith", "SuperSecretPassword!");
        bool isLoggedIn = loginPage.IsLoggedIn();
        
        isLoggedIn.Should().BeTrue();
    }

}