using Plastic.Infos.Data;
using Plastic.Molding.Data;

namespace Plastic.Molding.Cs.Data.EntityFramework
{
    public class EfDatabaseMold : EfMold<DatabaseInfo>, IDatabaseMold
    {
        public EfTableMoldCollection Fields { get; } = new EfTableMoldCollection();

        public void Manufacture(EfDossier dossier)
        {
            foreach (DatabaseInfo database in dossier.Info.Databases)
            {
                Pallet pallet = new Pallet();
                
                // create databasecontext
                CreateDatabaseContext(database, dossier, pallet);
                
                // create dataclass per table
                CreateDataclassPerTable(database, dossier, pallet);

                dossier.Pallets.Add(pallet);
            }

        }

        private void CreateDataclassPerTable(DatabaseInfo database, EfDossier dossier, Pallet pallet)
        {
            EfTableMold tableMold = new EfTableMold();
            foreach (TableInfo table in database.Tables)
            {
                tableMold.CreateDataclass(database, table, dossier, pallet);
            }
        }

        private void CreateDatabaseContext(DatabaseInfo database, EfDossier dossier, Pallet pallet)
        {
            CodeWriter cw = new CodeWriter();

            cw.WriteLine($"using {dossier.Info.Namespace}.Models;");
            cw.WriteLine("using System.CodeDom.Compiler;");
            cw.WriteLine("using Microsoft.EntityFrameworkCore;");
            //cw.WriteLine("using System.Data.Entity.ModelConfiguration.Conventions;");

            cw.Empty();

            cw.WriteLine($"namespace {dossier.Info.Namespace}.Dal");
            cw.Open();

            cw.CodeCoverage();
            cw.WriteLine($"public partial class {database.Name}Context : DbContext");

            cw.Open();

            foreach (TableInfo table in database.Tables)
            {
                cw.WriteLine($"public DbSet<{table.Name}> {table.Plural}{{ get; set; }}");
            }

            //cw.WriteLine($"protected override void OnModelCreating(DbModelBuilder modelBuilder)");
            //cw.Open();

            //cw.WriteLine($"modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();");

            //cw.Close();

            cw.Close();

            cw.Close();

            pallet.AddProduct("DbContext", "DAL", $@"{database.Name}Context.cs", cw);
        }
    }
}