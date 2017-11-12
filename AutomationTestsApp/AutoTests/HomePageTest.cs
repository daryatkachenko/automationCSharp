using System;
using NUnit.Framework;
using AutomationTestsApp.PageObjects;
namespace AutomationTestsApp.AutoTests
{
    public class HomePageTest:BaseTest
    {
        private HomePage _homePage;

        private HomePage HomePage => _homePage ?? (_homePage = new HomePage(Driver));

        [Test]
        [Description(@"
        stesps:
           1.open Home page")]
        public void CheckHomePage()
        {
            HomePage.OpenHomePage();
        }

    }
}
