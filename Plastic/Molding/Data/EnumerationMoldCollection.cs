using Plastic.Infos.Services;

namespace Plastic.Molding.Data
{
    public abstract class EnumerationMoldCollection<T> : MoldCollection<T, EnumerationInfo>
        where T : IEnumerationMold
    { }
}