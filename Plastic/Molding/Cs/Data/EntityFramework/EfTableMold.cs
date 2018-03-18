using Plastic.Infos.Data;
using Plastic.Molding.Data;

namespace Plastic.Molding.Cs.Data.EntityFramework
{
    public class EfTableMold : EfMold<TableInfo>, ITableMold
    {
        public static EfFieldMoldCollection FieldMolds { get; } = new EfFieldMoldCollection();

        protected void WriteUsings(CodeWriter cw)
        {
            cw.WriteLine("using ContosoUniversity.Enumerations;");
        }

        public void CreateDataclass(DatabaseInfo database, TableInfo table, EfDossier dossier, Pallet pallet)
        {
            CodeWriter cw = new CodeWriter();
            cw.WriteLine("using System;");
            cw.WriteLine("using System.CodeDom.Compiler;");
            cw.WriteLine("using System.Collections.Generic;");
            cw.WriteLine("using System.ComponentModel.DataAnnotations;");
            cw.WriteLine("using System.ComponentModel.DataAnnotations.Schema;");

            WriteUsings(cw);

            cw.Empty();

            cw.WriteLine($"namespace {dossier.Info.Namespace}.Models");
            cw.Open();

            cw.CodeCoverage();
            string isAbstract = table.Abstract ? "abstract " : "";
            if (table.ParentTableInfo != null)
            {
                cw.WriteLine($"public {isAbstract}partial class {table.Name} : {dossier.Info.Namespace}.Models.{table.ParentTableInfo.Name}");
            }
            else
            {
                cw.WriteLine($"public {isAbstract}partial class {table.Name}");
            }

            cw.Open();

            bool first = true;
            foreach (IFieldInfo fieldInfo in table.Fields)
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    cw.Empty();
                }
                IEfFieldMold fieldMold = FieldMolds.Create(fieldInfo);
                if (fieldMold == null)
                {
                    dossier.AddError("Mold not found.", fieldInfo);
                }
                else
                {
                    fieldMold.CreateDataclass(fieldInfo, cw);
                }
            }
            cw.Close();

            cw.Close();

            pallet.AddProduct($"{table.Name}", "Model", $@"{table.Name}.cs", cw);

        }
    }
}