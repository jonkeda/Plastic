using System;
using System.Collections.ObjectModel;

namespace Plastic.Bases
{
    public class TypeCollection<T> : Collection<T> 
    {
        private readonly TypeDictionary<T> _types = new TypeDictionary<T>();

        protected void AddType(Type type)
        {
            _types.Add(type);
        }

        public T Create(Type fromType)
        {
            return _types.Create(fromType);
        }
    }
}