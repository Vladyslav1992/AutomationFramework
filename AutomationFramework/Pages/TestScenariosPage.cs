using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationFramework.Pages
{
    public class TestScenariosPage
    {
        public TestScenariosPage()
        {
            PageFactory.InitElements(DriverDefinition.Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "h3 > a[href$='/login-form/']")]
        public IWebElement LoginFormScenario { get; set; }
    }
}
