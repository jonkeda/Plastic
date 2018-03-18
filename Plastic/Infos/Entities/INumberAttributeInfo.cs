using Plastic.Definitions.Data;

namespace Plastic.Infos.Entities
{
    public interface INumberAttributeInfo : IAttributeInfo
    {
        NumberType Type { get; }
    }
}