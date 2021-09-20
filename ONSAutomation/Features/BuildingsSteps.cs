using ONSAutomation.Drivers;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using QAssistant.Extensions;
using FluentAssertions;
using ONSAutomation.POM;
using System.Threading;

namespace ONSAutomation.Features
{
    [Binding]

    public class BuildingsSteps

    {

        BrowserDriver driver;
        ScenarioContext sc;

        public BuildingsSteps(BrowserDriver driver, ScenarioContext scenarioContext)
        {
            this.driver = driver;
            sc = scenarioContext;
        }

        Buildings Building = null;
       

        [Given(@"I am on Homepage")]
        public void GivenIAmOnHomepage()
        {
            
            driver.Current.Url.Should().Be("https://ons-stag.spacenextdoor.com/buildings");
        }
        
        [Given(@"I Click Add building button")]
        public void GivenIClickAddBuildingButton()
        {
            Building = new Buildings(driver.Current);
            Building.addBuilding.Click();
        }
        
        [Given(@"I Insert Building name in Building name field")]
        public void GivenIInsertBuildingNameInBuildingNameField()
        {
            Building.addBuildingName.SendKeys("testBuilding");
        }
        
        [Given(@"I Insert Contact name in Contact name field")]
        public void GivenIInsertContactNameInContactNameField()
        {
            Building.addContactName.SendKeys("testerName");
        }
        
        [Given(@"I Insert Contact number in Contact Number field")]
        public void GivenIInsertContactNumberInContactNumberField()
        {
            Building.addContactNumber.SendKeys("12345678");
        }
        
        [Given(@"I Insert Street Adress in Street Adress field")]
        public void GivenIInsertStreetAdressInStreetAdressField()
        {
            Building.addStreetAddress.SendKeys("SingaporeDelli2");
        }
        
        [Given(@"I Insert Zip Code in Zip Code field")]
        public void GivenIInsertZipCodeInZipCodeField()
        {
            Building.addZipCode.SendKeys("12345");
        }
        
        [Given(@"I Select City from City drop down list ""(.*)""")]
        public void GivenISelectCityFromCityDropDownList(string city)
        {
            Building.dropDownClickCity.SendKeys(city);
            Thread.Sleep(1000);
        }
        
        [Given(@"I Select Country from Country drop down list ""(.*)""")]
        public void GivenISelectCountryFromCountryDropDownList(string country)
        {
            Building.dropDownCountry.SendKeys(country);
        }
        
        [Given(@"I Select Status from Listing Status drop down list ""(.*)""")]
        public void GivenISelectStatusFromListingStatusDropDownList(string status)
        {
            Building.dropDownStatus.SendKeys(status);
        }
        
        [Given(@"I Insert Floorname")]
        public void GivenIInsertFloorname()
        {
            Building.floorName.SendKeys("2");
        }
        
        [Given(@"I insert Floor Level")]
        public void GivenIInsertFloorLevel()
        {
            Building.floorLevel.SendKeys("10");
        }
        
        [Given(@"I Click Save Button")]
        public void GivenIClickSaveButton()
        {
            Building.saveButton.Click();
        }
        
        [When(@"I validate current url is changed to ""(.*)""")]
        public void WhenIValidateCurrentUrlIsChangedTo(string url)
        {
            driver.Current.Url.Should().Be(url);
        }
        
        [Then(@"I validate building Building name is added")]
        public void ThenIValidateBuildingBuildingNameIsAdded()
        {
            Building.buildingList.Text.Contains("testerName");
        }
    }
}
