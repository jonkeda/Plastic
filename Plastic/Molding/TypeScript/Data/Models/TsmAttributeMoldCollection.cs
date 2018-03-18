using Plastic.Molding.Entities;

namespace Plastic.Molding.TypeScript.Data.Models
{
    public class TsmAttributeMoldCollection : AttributeMoldCollection<ITsmAttributeMold>
    {
        protected override void AddTypes()
        {
            AddType<TsmCalculatedAttributeMold>();
            AddType<TsmDecimalAttributeMold>();
            AddType<TsmIntAttributeMold>();
            AddType<TsmStringAttributeMold>();
            AddType<TsmDateTimTsmieldMold>();
            AddType<TsmParentAttributeMold>();
            AddType<TsmChildAttributeMold>();
            AddType<TsmMultipleFieldMold>();
            AddType<TsmEnumerationAttributeMold>();
            AddType<TsmBoolAttributeMold>();
        }
    }
}