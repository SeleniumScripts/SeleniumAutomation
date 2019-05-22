// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using OpenQA.Selenium;
using SiteNavigation.Utility;
using System.Configuration;
using SiteNavigation.Pages;
using static SiteNavigation.Pages.HomePageConstant;
using System;

namespace SiteNavigation
{
    [TestFixture]
    public class TestScripts
    {
        [OneTimeSetUp]
        public void BrowserIntandNavtoSite()
        {
            Driver.Initialize(BrowserType.Chrome);
            Driver.GoToWebSite(ConfigurationManager.AppSettings["WebSiteURL"]);
        }
        [Test, Category("DropDowntoListMenuItems"), Order(1)]
        public void DropDowntoListMenuItems()
        {
            HomePage.HoverSolutionsTab(ChooseDropDownMenu.SoultionsMenu);
            HomePage.HoverServicesTab(ChooseDropDownMenu.ServicesMenu);
            HomePage.HoverResourcesTab(ChooseDropDownMenu.ResoucesMenu);
            HomePage.HoverAboutTab(ChooseDropDownMenu.AboutMenu);
            HomePage.HoverBlogTab(ChooseDropDownMenu.BlogMenu);
        }
        [Test, Category("LeftScroll&RightScroll"), Order(2)]
        public void LeftandRightScrollFunctionality()
        {
            HomePage.NavPreviousResource();
            HomePage.NavNextResource();
        }
        [Test, Category("NavCareers"), Order(3)]
        public void NavCareers()
        {
            HomePage.Careers();
            HomePage.OfficeLocations();
        }

        [TestCase("400 E-Business Way, Suite 400 Cincinnati, OH 45241"), Order(4)]
        public void TestAddress(string address)
        {
            Assert.IsTrue(HomePage.ValidateAddress(address.Replace(" ", "").Replace(",", "")));
        }

        [OneTimeTearDown]
        public void Dispose()
        {
            Driver.CleanUp();
        }

    }
}

