using Plastic.Molding.Data;

namespace Plastic.Molding.Cs.Enumerations
{
    public class EnumerationMoldCollection : EnumerationMoldCollection<EnumerationMold>
    {
        protected override void AddTypes()
        {
            AddType<EnumerationMold>();
        }
    }
}