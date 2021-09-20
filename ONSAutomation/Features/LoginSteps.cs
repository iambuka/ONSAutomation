using FluentAssertions;
using ONSAutomation.Drivers;
using ONSAutomation.POM;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using System.Threading;

namespace ONSAutomation.Features
{
    [Binding]
    public class LoginSteps
    {
        BrowserDriver driver;
        ScenarioContext sc;
        public LoginSteps(BrowserDriver driver, ScenarioContext scenarioContext)
        {
            this.driver = driver;
            sc = scenarioContext;
        }

        Login Element = null;
      


        [Given(@"I am on the login page ""(.*)""")]
        public void GivenIAmOnTheLoginPage(string url)
        {
            Element = new Login(driver.Current);
            driver.Current.Url.Should().Be(url);
            
        }

        [Given(@"I click mail input field")]
        public void GivenIClickMailInputField()
        {
           
            Element.mailInput.Click();
        }

        [Given(@"I enter mail")]
        public void GivenIEnterMail()
        {
            Element.mailInput.SendKeys("bukamd@gmail.com");
        }



        [Given(@"I click sent otp button")]
        public void GivenIClickSentOtpButton()
        {
            Element.mailSubmit.Click();
            Thread.Sleep(25000);
        }
        
        //[Given(@"I insert otp ""(.*)""")]
        //public void GivenIInsertOtp(string p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"I click login button")]
        //public void GivenIClickLoginButton()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"I click choose company")]
        //public void GivenIClickChooseCompany()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"I choose snd company")]
        //public void GivenIChooseSndCompany()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[When(@"I Click save company button")]
        //public void WhenIClickSaveCompanyButton()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Then(@"Url should be ""(.*)""")]
        //public void ThenUrlShouldBe(string p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}
    }
}
