using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System.Configuration;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;

namespace SiteNavigation.Utility
{
    public static class Driver
    {

        public static IWebDriver Instance;
        public static string ParentWindowHandler = string.Empty;
        public static string CurrentFrameName = string.Empty;

        public static IWebDriver getInstance()
        {
            return Instance;
        }

        public static void CleanUp()
        {
            if (Instance != null)
                Instance.Quit();
        }

        public static void Initialize(BrowserType Browser)
        {
            switch (Browser)
            {
                case BrowserType.IE:
                    Driver.Instance = new InternetExplorerDriver();
                    break;
                case BrowserType.Chrome:
                    Driver.Instance = new ChromeDriver();
                    break;
                case BrowserType.Firefox:
                    Driver.Instance = new FirefoxDriver();
                    break;
            }

            MaximizeWindow();
        }

        public static void MaximizeWindow()
        {
            Instance.Manage().Window.Maximize();
        }

        public static void GoToWebSite(string url)
        {
            Driver.Instance.Navigate().GoToUrl(url);
         
        }


        public static IWebElement FindElement(By by)
        {
            try
            {
                Wait(1000);
                return Driver.Instance.FindElement(by);
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }

        public static void Wait(int TimeinSeconds)
        {
            Thread.Sleep(1000);
        }
        public static void MoveToIWebElement(IWebElement Se)
        {
            var element = Se;
            Actions actions = new Actions(Instance);
            actions.MoveToElement(element);
            actions.Perform();
        }

    }

    public enum BrowserType : int
    {
    IE = 1,
    Chrome = 2,
    Firefox = 3
    }
   
}
