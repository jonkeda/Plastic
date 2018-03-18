using Plastic.Molding.Data;

namespace Plastic.Molding.Cs.Data.EntityFramework
{
    public class EfFieldMoldCollection : FieldMoldCollection<IEfFieldMold>
    {
        protected override void AddTypes()
        {
            AddType<EfCalculatedFieldMold>();
            AddType<EfDecimalFieldMold>();
            AddType<EfIntFieldMold>();
            AddType<EfStringFieldMold>();
            AddType<EfDateTimeFieldMold>();
            AddType<EfParentFieldMold>();
            AddType<EfChildFieldMold>();
            AddType<EfMultipleFieldMold>();
            AddType<EfEnumerationFieldMold>();
            AddType<EfBoolFieldMold>();
        }
    }
}