using System;

namespace Plastic.Definitions.Data
{
    [Flags]
    public enum Crud
    {
        None = 0,
        Create = 1,
        Read = 2,
        Update = 4,
        Delete = 8,
        List = 16,
        All = 31
    }
}