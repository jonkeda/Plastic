using Plastic.Definitions.Data;

namespace Plastic.Infos.Data
{
    public interface INumberFieldInfo : IFieldInfo
    {
        NumberType Type { get; }
    }
}