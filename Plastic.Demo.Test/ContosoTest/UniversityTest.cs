using Microsoft.VisualStudio.TestTools.UnitTesting;
using Plastic.Definitions;
using Plastic.Demo.Contoso;
using Plastic.Infos;
using Plastic.Infos.Views;
using Plastic.Molding;
using Plastic.Molding.Cs.Data.EntityFramework;
using Plastic.Molding.Cs.Enumerations;
using Plastic.Molding.Cs.Views.Mvc;

namespace Plastic.Demo.Test.ContosoTest
{
    [TestClass]
    public class UniversityTest
    {
        [TestMethod]
        public void CreateDefinition()
        {
            ApplicationDefinition application = University.Create();
            ApplicationInfo applicationInfo = new ApplicationInfo();

            applicationInfo.Set(application);

            CrudCreator crudCreator = new CrudCreator();
            crudCreator.Create(applicationInfo);

            Shipment shipment = new Shipment();

            EfFactory factory = new EfFactory();
            factory.Manufacture(shipment, applicationInfo);

            EnumerationFactory enumerationFactory = new EnumerationFactory();
            enumerationFactory.Manufacture(shipment, applicationInfo);

            MvcFactory mvcFactory = new MvcFactory();
            mvcFactory.Manufacture(shipment, applicationInfo);

            shipment.Save(@"C:\Sources\Plastic\Plastic.University");
        }
    }
}
