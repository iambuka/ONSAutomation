﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;

namespace ONSAutomation.Drivers
{
    public class BrowserDriver : IBrowserDriver
    {
        private readonly TestContext _testRunContext;
        private readonly string _baseUrl;
        public IWebDriver Current;

        public BrowserDriver(TestContext testContext)
        {

            _testRunContext = testContext;
            _baseUrl = "https://ons-stag.spacenextdoor.com/login";
            Current = StartDriver("chrome"); //GridChrom for remote //chrome for local


        }

        private IWebDriver StartDriver(string browser)
        {
            return browser switch
            {
                "chrome" => GetChromeDriver(false),
                "chrome-headless" => GetChromeDriver(true),
                "firefox" => GetFirefoxDriver(),
                "edge" => GetEdgeDriver(),
                "GridChrome" => GetGridChrome(),

            };

        }
        public IWebDriver GetGridChrome()
        {
            //var chromeDriverService = ChromeDriverService.CreateDefaultService();
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");
            chromeOptions.AddArgument("--disable-dev-shm-usage");
            var chromeDriver = new RemoteWebDriver(new Uri("http://188.169.170.126:4444/"), chromeOptions)
            {
                Url = _baseUrl
            };
            return chromeDriver;
        }

        public void Navigate(string urlPart)
        {
            if (!Current.Url.EndsWith(urlPart))
            {
                Current.Navigate().GoToUrl($"{_baseUrl}{urlPart}");
                //RetryHelper.WaitFor(() => Current.Url.EndsWith(urlPart));
            }
        }

        #region Cross-Browser-Implemetation


        private IWebDriver GetEdgeDriver()
        {
            var edgeDriverServices = EdgeDriverService.CreateDefaultService(_testRunContext.DeploymentDirectory);
            var edgeDriverOptions = new EdgeOptions();
            edgeDriverOptions.PageLoadStrategy = PageLoadStrategy.Eager;

            var edgeDriver = new EdgeDriver(edgeDriverServices, edgeDriverOptions)
            {
                Url = _baseUrl
            };
            edgeDriver.Manage().Window.Maximize();
            return edgeDriver;

        }

        private IWebDriver GetFirefoxDriver()
        {
            var firefoxDriverService = FirefoxDriverService.CreateDefaultService(_testRunContext.DeploymentDirectory);
            firefoxDriverService.Host = "::1";
            var firefoxOptions = new FirefoxOptions();
            firefoxOptions.AddArgument("--start-maximized");
            
            var firefoxDriver = new FirefoxDriver(firefoxDriverService, firefoxOptions)
            {
                Url = _baseUrl
            };
            return firefoxDriver;
        }

        private IWebDriver GetChromeDriver(bool isHeadless)
        {
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");
            if (isHeadless)
            {
                chromeOptions.AddArgument("headless");
            }
            var chromeDriver = new ChromeDriver(chromeDriverService, chromeOptions)
            {
                Url = _baseUrl
            };

            if (isHeadless) chromeDriver.Manage().Window.Size = new Size(1920, 1080);

            return chromeDriver;
        }

        #endregion Cross-Browser-Implementation











    }
}
