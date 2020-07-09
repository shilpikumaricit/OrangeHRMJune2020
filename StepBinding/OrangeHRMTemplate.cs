using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace OrangeHRMJune2020.StepBinding
{
    [Binding]
    public class ManagerUserSteps
    {

        IWebDriver driver = new ChromeDriver();
        string userName;
        String orangeHrmUrl;
        LoginPage loginPage;

        [Given(@"Orange page url")]
        public void GivenOrangePageUrl()
        {
            orangeHrmUrl = "https://opensource-demo.orangehrmlive.com/index.php/auth/login";
        }

        [When(@"User enter (.*) and (.*)")]
        public void WhenUserEnterAnd(string username, string password)
        {
            Console.WriteLine("username: {0}, and password: {1}", username, password);
            loginPage = new LoginPage(driver);
            loginPage.LoginSuccess(orangeHrmUrl, username, password);

        }

        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            Console.WriteLine("Login Button Click");
        }


        [Then(@"Successful Login message should display")]
        public void ThenSuccessfulLoginMessageShouldDisplay()
        {
            Console.WriteLine("Login successful.");
        }

        [Then(@"Un Successful Login message should display")]
        public void ThenUnSuccessfulLoginMessageShouldDisplay()
        {
            string expectedMessage = "Invalid credentials";
            string actualErrorMessage = loginPage.verifyUnSuccessfulMessage();
            Assert.AreEqual(expectedMessage, actualErrorMessage);
        }

        [Then(@"Successful Login and Dashboard page should get displayed")]
        public void ThenSuccessfulLoginAndDashboardPageShouldGetDisplayed()
        {
            String expectedPage = "Dashboard";
            DashBoardPage dashBoardPage = new DashBoardPage();
            string actualPage = dashBoardPage.goToDashboardPage(driver);
            Assert.AreEqual(expectedPage, actualPage);
        }

    }
}
