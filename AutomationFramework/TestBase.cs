using System.Threading;
using NUnit.Framework;

namespace AutomationFramework
{
    class TestBase
    {
        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void ExecuteTest()
        {
            Thread.Sleep(5000);
        }

        [TearDown]
        public void CleanUp()
        {
            DriverDefinition.Driver.Quit();
        }
    }
}
