using Plastic.Definitions;

namespace Plastic.Infos
{
    public class InfoCollection<T, TD> : InfosCollection<T, TD>
        where T : Info<TD>
        where TD : Definition
    {
        protected sealed override void AddTypes()
        {
            AddType(typeof(T));
        }
    }

    public class InfoCollection<T, TD, TP> : InfosCollection<T, TD, TP>
        where T : Info<TD, TP>, IInfo<TD, TP>
        where TD : Definition
        where TP : IInfo
    {
        public InfoCollection(TP parent) : base(parent)
        {
        }

        protected sealed override void AddTypes()
        {
            AddType(typeof(T));
        }
    }
}