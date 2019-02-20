using AutomationFramework.Pages;
using OpenQA.Selenium.Chrome;

namespace AutomationFramework
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            DriverDefinition.Driver = new ChromeDriver();
            DriverDefinition.Driver.Navigate().GoToUrl(Config.baseUrl);
            DriverDefinition.Driver.Manage().Window.Maximize();
        }

        public static void FillLoginForm(params string[] credentials)
        {
            LoginScenarioPost loginScenarioPost = new LoginScenarioPost();

            loginScenarioPost.UserNameField.Clear();
            loginScenarioPost.UserNameField.SendKeys(credentials[0]);

            loginScenarioPost.UserNameField.Clear();
            loginScenarioPost.PasswordField.SendKeys(credentials[1]);

            loginScenarioPost.RepeatPasswordField.Clear();
            loginScenarioPost.RepeatPasswordField.SendKeys(credentials[1]);

            loginScenarioPost.LoginButton.Click();
        }
    }
}
