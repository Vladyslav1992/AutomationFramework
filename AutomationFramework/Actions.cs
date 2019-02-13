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
    }
}
