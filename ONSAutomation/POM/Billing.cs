using OpenQA.Selenium;
using QAssistant.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONSAutomation.POM
{
    public class Billing : AllBasePOM
    {
        IWebDriver driver;

        public Billing(IWebDriver driver) : base (driver)
        {
            this.driver = driver;
        }
        public IWebElement BillingPage => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/billing']"));
        public IWebElement x1 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement x2 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement x3 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement x4 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement x5 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement x6 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement x7 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement x8 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement x9 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement x10 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement x11 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));





    }
}
