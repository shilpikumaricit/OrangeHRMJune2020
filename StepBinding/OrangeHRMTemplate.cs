using System;
using System.Threading;
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

        [Given(@"User is at the Home Page")]
        public void GivenUserIsAtTheHomePage()
        {
            var rand = new Random();
            userName = "New" + rand.Next(0, 9999) + "user" + rand.Next(0, 9999);
            Console.WriteLine("Username : {0}", userName);
            var loginPage = new LoginPage(driver);
            loginPage.LoginSuccess();
        }
        
        [Given(@"Navigate to LogIn Page")]
        public void GivenNavigateToLogInPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"User enter (.*) and (.*)")]
        public void WhenUserEnterAnd(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            var dashboardPage = new DashBoardPage();
            dashboardPage.ClickUsers(driver);

            var systemUsersPage = new SystemUsersPage(driver, userName);
            systemUsersPage.ClickAdd();
            systemUsersPage.AddAndSaveUser();
            systemUsersPage.VerifyUser();
            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}
