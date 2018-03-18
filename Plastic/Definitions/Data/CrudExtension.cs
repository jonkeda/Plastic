namespace Plastic.Definitions.Data
{
    public static class CrudExtension
    {
        public static bool IsEqual(this Crud crudIs, Crud crud)
        {
            return (crudIs & crud) == crud;
        }
    }
}