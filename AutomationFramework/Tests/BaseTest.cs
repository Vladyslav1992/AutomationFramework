using System.Threading;
using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class BaseTest
    {
        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            DriverDefinition.Driver.Quit();
        }
    }
}
