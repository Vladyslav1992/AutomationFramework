using AutomationFramework.Pages;
using AutomationFramework.Pages.PageElements;

namespace AutomationFramework
{
    public static class NavigateTo
    {
        public static void OpenLoginFormThroughTestScenarios()
        {
            Menu menu = new Menu();
            TestScenariosPage testScenariosPage = new TestScenariosPage();

            menu.TestScenarios.Click();
            testScenariosPage.LoginFormScenario.Click();
        }
    }
}
