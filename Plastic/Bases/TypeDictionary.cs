using System;
using System.Collections.Generic;

namespace Plastic.Bases
{
    public class TypeDictionary<T> : Dictionary<Type, Type> 
    {
        public void Add(Type toType)
        {
            Type baseType = toType.BaseType;
            if (baseType.GenericTypeArguments != null
                && baseType.GenericTypeArguments.Length >= 1)
            {
                Add(baseType.GenericTypeArguments[0], toType);
            }
        }

        public T Create(Type fromType)
        {
            if (TryGetValue(fromType, out Type toType))
            {
                return (T)Activator.CreateInstance(toType);
            }
            return default(T);
        }
    }
}
