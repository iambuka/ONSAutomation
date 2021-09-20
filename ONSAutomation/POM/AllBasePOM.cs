using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONSAutomation.POM
{
    public class AllBasePOM
    {
        IWebDriver driver;
        public AllBasePOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public AllBasePOM()
        {

        }
    }
}
