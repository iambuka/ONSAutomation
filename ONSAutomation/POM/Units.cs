using OpenQA.Selenium;
using QAssistant.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONSAutomation.POM
{
    public class Units : AllBasePOM
    {
        

        IWebDriver driver;
        public Units(IWebDriver driver) : base (driver)
        {
            this.driver = driver;    
        }


        public IWebElement UnitsPage => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement AddUnitsType => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units/add-unit-type']"));
        public IWebElement AddUnitTypeName => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@class='form-control']"));
        public IWebElement UnitAttributes => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement SaveUnit => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@class='btn mr-2 btn-primary']"));
        public IWebElement AddUnit => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units/add-units']"));
        public IWebElement UnitText => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@role='rowgroup']"));
        public IWebElement Cctv => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@class='custom-control custom-checkbox'][2]"));
        public IWebElement x8 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement x9 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement x10 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));
        public IWebElement x11 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/units']"));


    }

}
