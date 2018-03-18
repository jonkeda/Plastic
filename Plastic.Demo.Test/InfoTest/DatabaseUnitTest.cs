using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plastic.Definitions;
using Plastic.Definitions.Data;
using Plastic.Infos;
using Plastic.Infos.Data;

namespace Plastic.Demo.Test.InfoTest
{
    [TestClass]
    public class DatabaseUnitTest
    {
        [TestMethod]
        public void CreateDefinition()
        {
            ApplicationDefinition application = DemoModel.Create();

            DatabaseDefinition database = application.Databases.First();

            Assert.AreEqual("Database", database.Name);
            Assert.AreEqual(1, database.Tables.Count);
        }

        [TestMethod]
        public void CreateInfo()
        {
            ApplicationDefinition applicationDefinition = DemoModel.Create();

            ApplicationInfo application = new ApplicationInfo();

            application.Set(applicationDefinition);

            DatabaseInfo database = application.Databases.First();

            Assert.AreEqual("Database", database.Name);
            Assert.AreEqual(1, database.Tables.Count);
        }

    }
}
