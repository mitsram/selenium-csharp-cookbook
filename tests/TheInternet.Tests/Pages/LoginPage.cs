using System;
using OpenQA.Selenium;

namespace TheInternet.Tests.Pages;

public class LoginPage : BasePage
{
    readonly By txtUsername = By.Id("username");
    readonly By txtPassword = By.Id("password");
    readonly By btnLogin = By.CssSelector("#login > button");

    public LoginPage(IWebDriver driver) : base(driver)
    {
    }

    public void Login(String username, String password)
    {
        _driver!.FindElement(txtUsername).SendKeys(username);
        _driver.FindElement(txtPassword).SendKeys(password);
        _driver.FindElement(btnLogin).Click();

    }

    public bool IsLoggedIn() 
    {
        return _driver!.FindElement(By.TagName("h2")).Text == "Secure Area";
    }
}