using OpenQA.Selenium;
using QAssistant.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONSAutomation.POM
{
    public class Buildings : AllBasePOM
    {
        IWebDriver driver;
        public Buildings(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //*[@href='/buildings']
        public IWebElement BuildingsPage => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/buildings']"));
        public IWebElement addBuilding => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/buildings/new-building']"));
        public IWebElement addContactName => driver.WaitUntilElementIsDisplayed(By.CssSelector("#contact_name"));
        public IWebElement addBuildingName => driver.WaitUntilElementIsDisplayed(By.CssSelector("#building_name"));
        public IWebElement addContactNumber => driver.WaitUntilElementIsDisplayed(By.CssSelector("#contact-number"));
        public IWebElement addStreetAddress => driver.WaitUntilElementIsDisplayed(By.CssSelector("#street-address"));
        public IWebElement addZipCode => driver.WaitUntilElementIsDisplayed(By.CssSelector("#zip-code"));
        public IWebElement dropDownClickCity => driver.WaitUntilElementIsDisplayed(By.XPath("//div[6]/span/fieldset/div/div[1]/div/div[1]/input"));
        public IWebElement floorName => driver.WaitUntilElementIsDisplayed(By.CssSelector("#floor_name_0"));
        public IWebElement floorLevel => driver.WaitUntilElementIsDisplayed(By.CssSelector("#floor_level_0"));
        public IWebElement saveButton => driver.WaitUntilElementIsDisplayed(By.CssSelector("button[type='submit']"));
        public IWebElement buildingList => driver.WaitUntilElementIsDisplayed(By.CssSelector("#buildingListing"));
        public IWebElement dropDownCountry => driver.WaitUntilElementIsDisplayed(By.XPath("//div[2]/div/div[7]/span/fieldset/div/div[1]/div/div[1]/input"));
        public IWebElement dropDownStatus => driver.WaitUntilElementIsDisplayed(By.XPath("//div[2]/div/div[8]/span/fieldset/div/div[1]/div/div[1]/input"));
        public IWebElement burgerMenu => driver.WaitUntilElementIsDisplayed(By.CssSelector("#__BVID__792__BV_toggle_"));
        public IWebElement burgerEdit => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/buildings/edit/49']"));
        public IWebElement editBuildngName => driver.WaitUntilElementIsDisplayed(By.CssSelector("#building_name"));
        public IWebElement editBuildingNumber => driver.WaitUntilElementIsDisplayed(By.CssSelector("#contact-number"));
        public IWebElement editBuildingAddress => driver.WaitUntilElementIsDisplayed(By.XPath("#map"));
        public IWebElement editBuildingZipcode => driver.WaitUntilElementIsDisplayed(By.XPath("#zip-code"));
        public IWebElement x5 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/buildings/edit/49']"));
        public IWebElement x16 => driver.WaitUntilElementIsDisplayed(By.XPath("//*[@href='/buildings']"));
    }

}