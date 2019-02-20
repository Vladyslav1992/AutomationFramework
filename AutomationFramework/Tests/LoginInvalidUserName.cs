using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationFramework.Tests
{
    public class LoginInvalidUserName : BaseTest
    {
        IAlert alert;

        [Test]
        public void Lessthat5Chars()
        {
            NavigateTo.OpenLoginFormThroughTestScenarios();
            Actions.FillLoginForm(Config.Credentials.Invalid.UserName.FourCharacters, Config.Credentials.Valid.password);

            alert = DriverDefinition.Driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertsTexts.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
        }
    }
}
