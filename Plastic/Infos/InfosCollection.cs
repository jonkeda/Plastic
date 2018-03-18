using System.Collections.Generic;
using System.Linq;
using Plastic.Bases;
using Plastic.Definitions;

namespace Plastic.Infos
{
    public abstract class InfosCollection<T, TD> : TypeCollection<T>
        where T : IInfo
        where TD : Definition
    {
        protected InfosCollection()
        {
            AddTypes();
        }

        protected void AddType<TT>()
            where TT : T
        {
            AddType(typeof(TT));
        }

        public void Set(IEnumerable<TD> definitions)
        {
            foreach (TD definition in definitions)
            {
                T info = Create(definition.GetType());
                if (info != null)
                {
                    info.Set(definition);

                    Add(info);
                }
            }
        }

        public T GetByName(string name)
        {
            return this.FirstOrDefault(i => i.Name == name);
        }

        protected abstract void AddTypes();
    }

    public abstract class InfosCollection<T, TD, TP> : InfosCollection<T, TD>
        where T : IInfo<TD, TP>
        where TD : Definition
        where TP : IInfo
    {
        private readonly TP _parent;

        protected InfosCollection(TP parent)
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