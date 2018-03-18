using System.Collections.ObjectModel;

namespace Plastic.Definitions
{
    public class DefinitionCollection<T> : Collection<T>
        where T : Definition
    {
        
    }

    public class DefinitionCollection<T, TP> : DefinitionCollection<T>
        where T : Definition<TP>
        where TP : Definition
    {
        private readonly TP _parent;

        public DefinitionCollection(TP parent)
        {
            _parent = parent;
        }

        protected override void InsertItem(int index, T item)
        {
            item.Parent = _parent;
            base.InsertItem(index, item);
        }

        protected override void SetItem(int index, T item)
        {
            item.Parent = _parent;
            base.SetItem(index, item);
        }
    }

}