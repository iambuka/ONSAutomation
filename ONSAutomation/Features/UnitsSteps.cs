using FluentAssertions;
using ONSAutomation.Drivers;
using ONSAutomation.POM;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using QAssistant.Extensions;

namespace ONSAutomation.Features
{
    [Binding]
    public class UnitsSteps
    {
        BrowserDriver driver;
        ScenarioContext sc;
        public UnitsSteps(BrowserDriver driver, ScenarioContext scenarioContext)
        {
            this.driver = driver;
            sc = scenarioContext;
        }
        Units Unit = null;
        [Given(@"I am logged in on ""(.*)""")]
        public void GivenIAmLoggedInOn(string Url)
        {
            driver.Current.Url.Should().Be(Url);
        }

        // [Given(@"I am logged in on ""(.*)""")]
        // public void GivenIAmLoggedInOn()
        //{
        //  driver.Current.Url.Should().Be("https://ons-stag.spacenextdoor.com/buildings");
        //}

        [Given(@"I click units page")]
        public void GivenIClickUnitsPage()
        {
            Unit.UnitsPage.Click();
            
        }
        
        [Given(@"I click add units type")]
        public void GivenIClickAddUnitsType()
        {
            Unit.AddUnitsType.Click();
        }
        
        [Given(@"I click name input field")]
        public void GivenIClickNameInputField()
        {
            Unit.AddUnitTypeName.Click();
        }
        
        [Given(@"I input ""(.*)"" unit name")]
        public void GivenIInputUnitName(string unitName)
        {
            Unit.AddUnitTypeName.SendKeys(unitName);
        }
        
        [Given(@"I choose ""(.*)"" attributes option with mark")]
        public void GivenIChooseAttributesOptionWithMark(string quantity)
        {
            if (quantity == "all")
            {
                for (int i = 1; i < 5; i++)
                {
                    driver.Current.Click(By.XPath($"//*[@class='custom-control custom-checkbox{i}']"));

                }
            }
            else if (quantity=="cctv")
            {
                Unit.Cctv.Click();
            }
        }
        
        [Given(@"I click save button")]
        public void GivenIClickSaveButton()
        {
            Unit.SaveUnit.Click();
        }
        
        [Given(@"I am redirected to ""(.*)""")]
        public void GivenIAmRedirectedTo()
        {
            driver.Current.Url.Should().Be("https://ons-stag.spacenextdoor.com/units");
        }
        
        [When(@"I click Add Unit button")]
        public void WhenIClickAddUnitButton()
        {
            Unit.AddUnit.Click();
        }

        [Then(@"Should be unit with name ""(.*)""")]
        public void ThenShouldBeUnitWithName(string unitName)
        {
            Unit.UnitText.Should().Be(unitName,"This verifies if unit is add");
        }

    }
}
