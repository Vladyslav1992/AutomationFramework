using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationFramework.Pages
{
    class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(DriverDefinition.Driver, this); 
        }

        [FindsBy(How = How.ClassName, Using = "mh-header-title")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.TagName, Using = "h2")]
        public IWebElement SubHeader { get; set; }

        [FindsBy(How = How.CssSelector, Using = "h1[value='Introduction']")]
        public IWebElement HeadLine { get; set; }

        [FindsBy(How = How.CssSelector, Using = "img[src$='.png']")]
        public IWebElement Image { get; set; }
    }
}
