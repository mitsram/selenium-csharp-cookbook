using System;
using OpenQA.Selenium;
using TheInternet.Tests.Pages;

namespace TheInternet.Tests.Pages;

public class LoginPage : BasePage
{
    readonly By txtUsername = By.Id("");
    readonly By txtPassword = By.Id("");
    readonly By btnLogin = By.Id("");

    public LoginPage(IWebDriver driver)
    {
        _driver = driver;
    }

    public void Login(String username, String password)
    {
        _driver.FindElement(txtUsername).SendKeys(username);
        _driver.FindElement(txtPassword).SendKeys(password);
        _driver.FindElement(btnLogin).Click();
    }
}