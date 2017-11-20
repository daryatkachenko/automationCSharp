using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using System.IO;

namespace AutomationTestsApp.DriverManager
{
    public static class DriverFactory
    {
        private static String _driverDirectory = Path.Combine(TestContext.CurrentContext.TestDirectory, "DriverManager");

        public static IWebDriver Create(DriverType driverType)
        {

            switch (driverType)
            {

                case DriverType.Firefox;
                    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(_driverDirectory, "geckodriver.exe");
                    service.FirefoxBinaryPath = @"";
                    return new FirefoxDriver(service);

                case DriverType.Opera:
                    OperaOptions optionsOpera = new OperaOptions();
                    optionsOpera.BinaryLocation = @"C:\Program Files\Opera\launcher.exe";
                    return new OperaDriver(Path.Combine(TestContext.CurrentContext.TestDirectory, "DriverManager"), optionsOpera);

                default:
                    return new ChromeDriver(_driverDirectory);
            }
        }

    }
}
