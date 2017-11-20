using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestsApp.PageObjects
{
    public class BaseObject
    {
        protected readonly IWebDriver driver;

        public BaseObject(IWebDriver driver){
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }
    }
}
