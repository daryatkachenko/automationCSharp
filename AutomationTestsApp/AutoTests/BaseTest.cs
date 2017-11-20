using System;
using OpenQA.Selenium;
using NUnit.Framework;
using System.IO;
using AutomationTestsApp.DriverManager;
using System.Configuration;
namespace AutomationTestsApp.AutoTests
{
    [TestFixture]
    public class BaseTest
    {
        private static DriverType _driverType;
        protected IWebDriver Driver { get; set; }

        static BaseTest()
        {
            String value = ConfigurationManager.AppSettings["DriverType"].ToString();
            _driverType = (DriverType)Enum.Parse(typeof(DriverType), value);
        }

        [OneTimeSetUp]
        public void CreateDriver()
        {
            Driver = DriverFactory.Create(_driverType);
            Driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            Driver.Close();
        }
    }
}
