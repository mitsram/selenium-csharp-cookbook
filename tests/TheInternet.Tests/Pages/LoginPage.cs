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

    public void Login(string username, string password)
    {
        driver!.FindElement(txtUsername).SendKeys(username);
        driver.FindElement(txtPassword).SendKeys(password);
        driver.FindElement(btnLogin).Click();

    }

    public bool IsLoggedIn() 
    {
        return driver!.FindElement(By.TagName("h2")).Text == "Secure Area";
    }
}