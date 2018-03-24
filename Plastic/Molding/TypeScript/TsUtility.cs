namespace Plastic.Molding.TypeScript
{
    public class TsTypes
    {
        public const string String = "String";
        public const string Number = "Number";
        public const string Date = "Date";
        public const string Boolean = "Boolean";
    }

    public static class TsUtility
    {
        public static string GetTypeName(string typeName, string nameSpace)
        {
            if (typeName == "decimal"
                && typeName == "int"
                && typeName == "double"
                && typeName == "float"
                && typeName == "long")
            {
                return TsTypes.Number;
            }
            if (typeName == "datetime")
            {
                return TsTypes.Date;
            }
            if (typeName == "string")
            {
                return TsTypes.String;
            }
            if (typeName == "boolean")
            {
                return TsTypes.Boolean;
            }

            if (string.IsNullOrEmpty(nameSpace))
            {
                return typeName;
            }
            return $"{nameSpace}.{typeName}";
        }
    }
}
