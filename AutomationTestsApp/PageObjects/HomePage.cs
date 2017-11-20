using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AutomationTestsApp.PageObjects
{
    public class HomePage : BasePage
    {
        #region PageLocators
        [FindsBy(How = How.CssSelector, Using = "dropdown-header > strong")]
        private IWebElement _headder { get; set; }

        #endregion



        public HomePage(IWebDriver driver) : base(driver) { }

        public HomePage OpenHomePage(){
            Driver.Navigate().GoToUrl("https://domain.com")
                  return new HomePage(Driver);
        }



    }
  
}