using OpenQA.Selenium.Support.PageObjects;

namespace AutomationFramework.Pages
{
    class TestScenariosPage
    {
        public TestScenariosPage()
        {
            PageFactory.InitElements(DriverDefinition.Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = )]
    }
}
