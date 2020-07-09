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


        public void LoginSuccess(string url, string userName, string passWord)
        {
            //maximizing the window
            driver.Manage().Window.Maximize();
            //opening the url
            driver.Navigate().GoToUrl(url);

            // login to system
            username.SendKeys(userName);
            password.SendKeys(passWord);
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

        internal string verifyUnSuccessfulMessage()
        {
            IWebElement webElement = driver.FindElement(By.Id("spanMessage"));
            return webElement.Text;
        }
    }
}
