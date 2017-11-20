using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestsApp.PageObjects
{
    public class BasePage
    {
        protected IWebDriver Driver { get; private set; }
        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver,this);
        }
    }
}
