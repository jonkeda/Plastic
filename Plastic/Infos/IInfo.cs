using Plastic.Definitions;

namespace Plastic.Infos
{
    public interface IInfo
    {
        string Name { get; set; }

        string Description { get; set; }

        void Set(Definition definition);
    }
}