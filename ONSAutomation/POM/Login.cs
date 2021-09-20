using OpenQA.Selenium;
using QAssistant.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONSAutomation.POM
{
    public class Login : AllBasePOM
    {


        IWebDriver driver;
        public Login(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public IWebElement mailInput => driver.WaitUntilElementIsDisplayed(By.CssSelector("#login-email"));
        public IWebElement mailSubmit => driver.WaitUntilElementIsDisplayed(By.CssSelector("button[type='submit']"));
        public IWebElement Otp => driver.WaitUntilElementIsDisplayed(By.CssSelector("#otp-code"));
        public IWebElement loginButton => driver.WaitUntilElementIsDisplayed(By.XPath("button[type='submit']"));
        public IWebElement chooseCompany => driver.WaitUntilElementIsDisplayed(By.CssSelector("div.vs__selected-options"));
        public IWebElement sndCompany => driver.WaitUntilElementIsDisplayed(By.CssSelector("li[id='vs1__option-0']"));
        public IWebElement userNav => driver.WaitUntilElementIsDisplayed(By.CssSelector("span.user-status"));
        public IWebElement saveCompany => driver.WaitUntilElementIsDisplayed(By.XPath("//button[text()='Save']"));
        public IWebElement x1 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@id='login-email']"));
        public IWebElement x2 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[contains(text(),'Welcome to One Space')]"));
        public IWebElement x3 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@class='form-control']"));
        public IWebElement x4 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement x5 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@class='btn mr-2 btn-primary']"));
        public IWebElement x6 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units/add-units']"));
        public IWebElement x7 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@role='rowgroup']"));
        public IWebElement Cctv => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@class='custom-control custom-checkbox'][2]"));
        public IWebElement x8 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement x9 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement x10 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement x11 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));


    }

}
