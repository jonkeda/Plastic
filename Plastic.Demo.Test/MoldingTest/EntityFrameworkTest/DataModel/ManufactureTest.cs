using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plastic.Definitions;
using Plastic.Infos;
using Plastic.Molding;
using Plastic.Molding.Cs.Data.EntityFramework;

namespace Plastic.Demo.Test.MoldingTest.EntityFrameworkTest.DataModel
{
    [TestClass]
    public class ManufactureTest
    {
        [TestMethod]
        public void CreateDefinition()
        {
            ApplicationDefinition application = DemoModel.Create();
            ApplicationInfo applicationInfo = new ApplicationInfo();

            applicationInfo.Set(application);

            EfFactory factory = new EfFactory();

            Shipment shipment = new Shipment();
            factory.Manufacture(shipment, applicationInfo);
        }
    }
}
