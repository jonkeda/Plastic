using Plastic.Definitions;

namespace Plastic.Infos
{
    public abstract class Info : IInfo
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public string DisplayName { get; set; }

        public virtual void Set(Definition definition)
        {
            Name = definition.Name;
            Description = definition.Description;

            if (string.IsNullOrEmpty(definition.DisplayName))
            {
                DisplayName = definition.Name;
            }
            else
            {
                DisplayName = definition.DisplayName;
            }

            DoSet(definition);
        }

        protected virtual void DoSet(Definition definition)
        { }

        public void Set(Info info)
        {
            Name = info.Name;
            Description = info.Description;
            DisplayName = info.DisplayName;
        }
    }

    public interface IInfo<T> : IInfo
        where T : Definition
    { }

    public interface IInfo<T, TP> : IInfo<T>
        where T : Definition
        where TP : IInfo
    {
        TP Parent { get; set; }
    }

    public abstract class Info<T> : Info
        where T : Definition
    {
        protected override void DoSet(Definition definition)
        {
            OnSet(definition as T);
        }

        protected virtual void OnSet(T definition)
        { }
    }

    public abstract class Info<T, TP> : Info<T>, IInfo<T, TP>
        where T : Definition
        where TP : IInfo
    {
        public TP Parent { get; set; }
    }
}