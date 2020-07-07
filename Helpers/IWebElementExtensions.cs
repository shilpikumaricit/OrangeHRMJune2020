using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace OrangeHRMJune2020
{
    public static class IWebElementExtensions
    {
        //[Obsolete]
        [Obsolete]
        public static IWebElement Wait(IWebDriver driver, TimeSpan time, By element)
        {
            return new WebDriverWait(driver, time).Until(ExpectedConditions.ElementToBeClickable(element));
        }
    }
}
