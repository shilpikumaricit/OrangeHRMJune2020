using System;
using OpenQA.Selenium;
namespace OrangeHRMJune2020
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driverFromTests)
        {
            driver = driverFromTests;
        }
        IWebElement username => driver.FindElement(By.Id("txtUsername"));
        IWebElement password => driver.FindElement(By.Id("txtPassword"));
        IWebElement loginBtn => driver.FindElement(By.Id("btnLogin"));


        public void LoginSuccess()
        {
            //maximizing the window
            driver.Manage().Window.Maximize();
            //opening the url
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/auth/login");

            // login to system
            username.SendKeys("Admin");
            password.SendKeys("admin123");
            loginBtn.Click();
        }
        public void LoginFailure()
        {
            //maximizing the window
            driver.Manage().Window.Maximize();
            //opening the url
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/auth/login");

            username.SendKeys("erint");
            password.SendKeys("sdf");
            loginBtn.Click();
        }
    }
}
