namespace Plastic.Molding.TypeScript
{
    public static class TsUtility
    {
        public static string GetTypeName(string typeName)
        {
            if (typeName == "string")
            {
                return "String";
            }

            return typeName;
        }
    }
}
