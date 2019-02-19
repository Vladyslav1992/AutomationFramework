using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationFramework.Pages
{
    class LoginScenarioPost
    {
        public LoginScenarioPost()
        {
            PageFactory.InitElements(DriverDefinition.Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "input[name='userid']")]
        public IWebElement UserNameField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[name^='pass']")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[name*='repeat']")]
        public IWebElement RepeatPasswordField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[value='LOGIN']")]
        public IWebElement LoginButton { get; set; }
    }
}
