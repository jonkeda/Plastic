using Plastic.Bases;

namespace Plastic.Molding
{
    public abstract class MoldCollection<T, TI>
    {
        private readonly TypeDictionary<T> _types = new TypeDictionary<T>();

        protected MoldCollection()
        {
            AddTypes();
        }

        protected void AddType<TM>()
            where TM : T
        {
            _types.Add(typeof(TM));
        }

        public T Create(TI type)
        {
            return _types.Create(type.GetType());
        }

        protected abstract void AddTypes();
    }
}