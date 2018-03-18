using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plastic.Definitions;
using Plastic.Infos;

namespace Plastic.Demo.Test.InfoTest
{
    [TestClass]
    public class ApplicationUnitTest
    {
        [TestMethod]
        public void CreateDefinition()
        {
            ApplicationDefinition application = DemoModel.Create();

            Assert.AreEqual("Demo", application.Name);
            Assert.AreEqual(application.Databases.Count, 1);
        }

        [TestMethod]
        public void CreateInfo()
        {
            ApplicationDefinition application = DemoModel.Create();

            ApplicationInfo applicationInfo = new ApplicationInfo();
            
            applicationInfo.Set(application);

            Assert.AreEqual("Demo", applicationInfo.Name);
            Assert.AreEqual(applicationInfo.Databases.Count, 1);
        }

    }
}
