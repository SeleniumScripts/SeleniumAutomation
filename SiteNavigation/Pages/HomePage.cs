using OpenQA.Selenium;
using SiteNavigation.Utility;
using static SiteNavigation.Pages.HomePageConstant;
using OpenQA.Selenium.Interactions;

namespace SiteNavigation.Pages
{
    public class HomePage

    {
        public static void HoverSolutionsTab(string ChooseDropDownMenu)
        {
            Driver.Wait(100);
            var NavtoSolutionsTab = Driver.Instance.FindElement(By.XPath(ChooseDropDownMenu));
            Driver.MoveToIWebElement(NavtoSolutionsTab);
        }
        public static void HoverServicesTab(string ChooseDropDownMenu)
        {
            Driver.Wait(100);
            var NavtoServicesTab = Driver.Instance.FindElement(By.XPath(ChooseDropDownMenu));
            Actions action = new Actions(Driver.Instance);
            Driver.MoveToIWebElement(NavtoServicesTab);
        }
        public static void HoverResourcesTab(string ChooseDropDownMenu)
        {
            Driver.Wait(100);
            var NavtoResourcesTab = Driver.Instance.FindElement(By.XPath(ChooseDropDownMenu));
            Driver.MoveToIWebElement(NavtoResourcesTab);
        }
        public static void HoverAboutTab(string ChooseDropDownMenu)
        {
            Driver.Wait(100);
            var NavtoAboutTab = Driver.Instance.FindElement(By.XPath(ChooseDropDownMenu));
            Driver.MoveToIWebElement(NavtoAboutTab);
        }
        public static void HoverBlogTab(string ChooseDropDownMenu)
        {
            Driver.Wait(100);
            var NavtoBlogTab = Driver.Instance.FindElement(By.XPath(ChooseDropDownMenu));
            Driver.MoveToIWebElement(NavtoBlogTab);
        }
        public static void NavPreviousResource()
        {
            Driver.Wait(100);
            IWebElement slider = Driver.Instance.FindElement(By.Id(ChooseDropDownMenu.Slider));
            Driver.MoveToIWebElement(slider);
            var NavPreviousResoucre = slider.FindElement(By.ClassName(ChooseDropDownMenu.NavPreviousResoucre));
            Actions actions = new Actions(Driver.Instance).MoveToElement(NavPreviousResoucre);
            actions.Click().Perform();
        }
        public static void NavNextResource()
        {
            Driver.Wait(100);
            IWebElement slider = Driver.Instance.FindElement(By.Id(ChooseDropDownMenu.Slider));
            Driver.MoveToIWebElement(slider);
            var NavNextResoucre = slider.FindElement(By.ClassName(ChooseDropDownMenu.NavNextResoucre));
            Actions actions = new Actions(Driver.Instance).MoveToElement(NavNextResoucre);
            actions.Click().Perform();
        }
        public static void Careers()
        {
            Driver.Wait(100);
            IWebElement sitemap = Driver.Instance.FindElement(By.ClassName(ChooseDropDownMenu.Sitemap));
            Driver.MoveToIWebElement(sitemap);
            var Careers = Driver.Instance.FindElement(By.XPath(ChooseDropDownMenu.Careers));
            Actions actions = new Actions(Driver.Instance).MoveToElement(Careers);
            actions.Click().Perform();
        }
        public static bool ValidateAddress(string addressToValidate)
        {
            By td = By.CssSelector("td.bg-hobsons");
            var adressTableCells = Driver.Instance.FindElements(td);
            foreach (var addresscell in adressTableCells)
            {
                var address = addresscell.FindElement(By.TagName("address")).Text;
                address = address.Replace(" ", "").Replace(",", "").Replace("\n", "").Replace("\r", "").ToUpper();
                if (address.Contains(addressToValidate.ToUpper()))
                {
                    return true;
                }
            }
            return false;
        }
        public static void OfficeLocations()
        {
            Driver.Wait(600);
            IWebElement officeLocations = Driver.Instance.FindElement(By.ClassName(ChooseDropDownMenu.OfficeLocations));
            Driver.MoveToIWebElement(officeLocations);
            var ContactUs = officeLocations.FindElement(By.XPath(ChooseDropDownMenu.CGHLocation));
            Actions actions = new Actions(Driver.Instance).MoveToElement(ContactUs);
            Driver.Wait(100);
            actions.Click().Perform();
        }       
    }
}
