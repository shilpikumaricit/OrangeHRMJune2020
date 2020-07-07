using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OrangeHRMJune2020
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();
        string userName;

        [OneTimeSetUp]
        public void Before()
        {
            var rand = new Random();
            userName = "New" + rand.Next(0, 9999) + "user" + rand.Next(0, 9999);
            Console.WriteLine("Username : {0}", userName);
            var loginPage = new LoginPage(driver);
            loginPage.LoginSuccess();
        }

        

        [OneTimeTearDown]
        public void AfterEachTest()
        {
            driver.Quit();
        }

        
        [Category("IntegrationTests")]
        [Test]   
        public void IT1_AddnValidate()
        {
            
            var dashboardPage = new DashBoardPage();
            dashboardPage.ClickUsers(driver);

            var systemUsersPage = new SystemUsersPage(driver, userName);
            systemUsersPage.ClickAdd();
            systemUsersPage.AddAndSaveUser();
            systemUsersPage.VerifyUser();
        }


        [Test]
        public void IT3_DeleteNValidate()
        {
            Thread.Sleep(5000);
            var dashboardPage = new DashBoardPage();
            dashboardPage.ClickUsers(driver);

            var systemUsersPage = new SystemUsersPage(driver, userName);
            systemUsersPage.delete();
            //verify if the user is deleted
            systemUsersPage.VerifyUser();
            //create method & logic to delete
        }

        [Test]
        [Category("UnitTests")]
        public void IT2_EditnValidate()
        {
            //Assert.True();
        }

    }
}