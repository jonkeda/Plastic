namespace Plastic.Molding.TypeScript
{
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
                return "number";
            }
            if (typeName == "datetime")
            {
                return "date";
            }
            if (typeName == "string")
            {
                return "string";
            }
            if (typeName == "boolean")
            {
                return "boolean";
            }

            if (string.IsNullOrEmpty(nameSpace))
            return typeName;
            return $"{nameSpace}.{typeName}";
        }
    }
}
