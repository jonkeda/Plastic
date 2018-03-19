using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plastic.Definitions;
using Plastic.Infos;
using Plastic.Molding;
using Plastic.Molding.TypeScript.Data.Models;
using Plastic.Molding.TypeScript.Data.Services;

namespace Plastic.Demo.Test.Hypoloan
{
    [TestClass]
    public class HypoloanTest
    {
        [TestMethod]
        public void Create()
        {
            ApplicationDefinition application = ApplicationDefinition.Load(@"C:\Sources\Plastic\Plastic.Demo.Test\Hypoloan\Hypoloan.xml");

            ApplicationInfo applicationInfo = new ApplicationInfo();

            applicationInfo.Set(application);

            Shipment shipment = new Shipment();

            TsmFactory factory = new TsmFactory();

            factory.Manufacture(shipment, applicationInfo);
            
            TssFactory sfactory = new TssFactory();

            sfactory.Manufacture(shipment, applicationInfo);

            shipment.Save(@"C:\Sources\Plastic\Plastic.Demo.Test\Hypoloan\Files");

        }
    }
}
