using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace OrangeHRMJune2020
{
    public class DashBoardPage
    {

       

        internal void ClickUsers(IWebDriver driver)
        {
            // Identfying the user management
            //var Admin = driver.FindElement(By.Id("menu_admin_viewAdminModule"));
            //Actions action = new Actions(driver);
            //action.MoveToElement(Admin).Perform();
            //Thread.Sleep(5000);
           // action.MoveToElement(driver.FindElement(By.Id("menu_admin_UserManagement"))).Perform();
            // click on User
           driver.FindElement(By.Id("menu_admin_viewAdminModule")).Click();

        }

        internal string goToDashboardPage(IWebDriver driver)
        {
           return driver.FindElement(By.XPath("1")).Text;
        }
    }
}
