using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plastic.Definitions;
using Plastic.Definitions.Data;
using Plastic.Infos;
using Plastic.Infos.Data;

namespace Plastic.Demo.Test.InfoTest
{
    [TestClass]
    public class FieldUnitTest
    {
        [TestMethod]
        public void CreateDefinition()
        {
            ApplicationDefinition application = DemoModel.Create();

            DatabaseDefinition database = application.Databases.First();
            TableDefinition table = database.Tables.First();
            FieldDefinition field = table.Fields.First();

            Assert.AreEqual("ID", field.Name);
        }

        [TestMethod]
        public void CreateInfo()
        {
            ApplicationDefinition applicationDefinition = DemoModel.Create();

            ApplicationInfo application = new ApplicationInfo();

            application.Set(applicationDefinition);

            DatabaseInfo database = application.Databases.First();
            TableInfo table = database.Tables.First();
            IFieldInfo field = table.Fields.First();

            Assert.AreEqual("ID", field.Name);
        }
    }
}
