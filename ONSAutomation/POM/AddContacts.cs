using OpenQA.Selenium;
using QAssistant.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONSAutomation.POM
{
    public class AddContacts : AllBasePOM
    {
        IWebDriver driver;

        public AddContacts(IWebDriver driver) : base (driver)
        {
            this.driver = driver;
        }

        public AddContacts()
        {
            
        }

        public IWebElement Male => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='login-email']"));
        public IWebElement Mail2 => driver.WaitUntilElementIsDisplayed(By.CssSelector("button[type='submit']"));
        public IWebElement Otp => driver.WaitUntilElementIsDisplayed(By.CssSelector("#otp-code"));
        public IWebElement loginButton => driver.WaitUntilElementIsDisplayed(By.XPath("button[type='submit']"));
        public IWebElement chooseCompany => driver.WaitUntilElementIsDisplayed(By.CssSelector("div.vs__selected-options"));
        public IWebElement sndCompany => driver.WaitUntilElementIsDisplayed(By.CssSelector("li[id='vs1__option-0']"));
        public IWebElement userNav => driver.WaitUntilElementIsDisplayed(By.CssSelector("span.user-status"));
        public IWebElement saveCompany => driver.WaitUntilElementIsDisplayed(By.XPath("//button[text()='Save']"));
        public IWebElement x8 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement x9 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement x10 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement x11 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));






    }
}
