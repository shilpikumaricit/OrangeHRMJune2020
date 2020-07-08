using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace OrangeHRMJune2020
{
    public class SystemUsersPage
    {
        string userName;
        private IWebDriver driver;

        public SystemUsersPage(IWebDriver driver, string userName)
        {
            this.driver = driver;
            this.userName = userName;
        }   

        internal void ClickAdd()
        {
            // Clicking on Add Button
            driver.FindElement(By.XPath("//input[@value='Add']")).Click();

        }

        internal void AddAndSaveUser()
        {
            //Selecting from User Role dropdown box.
            SelectElement userRole = new SelectElement(driver.FindElement(By.Id("systemUser_userType")));
            userRole.SelectByText("Admin");

            var empName = driver.FindElement(By.Id("systemUser_employeeName_empName"));
            empName.SendKeys("L");
            var list = driver.FindElements(By.XPath("//div[@class='ac_results']/ul/li"));
            list[0].Click();


            driver.FindElement(By.Id("systemUser_userName")).SendKeys(userName);

            Thread.Sleep(2000);
            var savebtn = driver.FindElement(By.XPath("//input[@value='Save']"));
            savebtn.Click();


        }

        
        internal void VerifyUser()
        {
            // Implementing Explicit Wait

            IWebElementExtensions.Wait(driver, TimeSpan.FromSeconds(10), By.Id("resultTable"));

            var recordsCount = driver.FindElements(By.Id("resultTable")).Count;
            bool recordFound = false;
            for (int i = 1; i <= recordsCount; i++)
            {
                var recordUserName = driver.FindElement(By.XPath("//table[@id='resultTable']/tbody/tr[" + i + "]/td[2]/a")).Text;

                if (recordUserName == userName)
                {
                    recordFound = true;
                    break;
                }
            }

            if (recordFound)
            {
                Console.WriteLine("Record {0} is created successfully and exists in records list", userName);
            }
            else
                Console.WriteLine("Record {0} is created but does not exists in records list", userName);
        }

        internal void delete()
        {
            //Username index
            // Search UserId
            driver.FindElement(By.Id("searchSystemUser_userName")).SendKeys(userName);

            //Click on Search button
            driver.FindElement(By.Id("searchBtn")).Click();


            //Delete user
            driver.FindElement(By.XPath("//input[contains(@name,'chkSelectRow[]')]")).Click();
            driver.FindElement(By.XPath("//input[contains(@id,'btnDelete')]")).Click();

            driver.FindElement(By.Id("dialogDeleteBtn")).Click();
            //Verify the user Id is Deleted
           // Assert.False(SearchUsername(userName));

        }
    }
}
