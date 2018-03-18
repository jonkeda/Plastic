using Plastic.Definitions;
using Plastic.Definitions.Data;

namespace Plastic.Demo
{
    public class DemoModel
    {
        public static ApplicationDefinition Create()
        {
            ApplicationDefinition application = new ApplicationDefinition
            {
                Name = "Demo"
            };

            DatabaseDefinition database = new DatabaseDefinition()
            {
                Name = "Database"
            };
            application.Databases.Add(database);

            TableDefinition table =  new TableDefinition()
            {
                Name = "Customer"
            };
            database.Tables.Add(table);

            table.Fields.Add(new IntFieldDefinition { Name = "ID" });
            table.Fields.Add(new StringFieldDefinition { Name = "FullName" });
            table.Fields.Add(new IntFieldDefinition { Name = "BirthDate" });


            return application;
        }
    }
}
