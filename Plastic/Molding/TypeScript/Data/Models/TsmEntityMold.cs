using Plastic.Infos.Entities;
using Plastic.Molding.Entities;

namespace Plastic.Molding.TypeScript.Data.Models
{
    public class TsmEntityMold : TsmMold<EntityInfo>, IEntityMold
    {
        public static TsmAttributeMoldCollection AttributeMolds { get; } = new TsmAttributeMoldCollection();

        protected void WriteUsings(CodeWriter cw)
        {
            //cw.WriteLine("using ContosoUniversity.Enumerations;");
        }

        public void CreateDataclass(ModelInfo database, EntityInfo table, TsmDossier dossier, Pallet pallet)
        {
            CodeWriter cw = new CodeWriter();
            CreateDataclass(cw, table, dossier);
            pallet.AddProduct($"{table.Name}", "Model", $@"{table.Name}.cs", cw);
        }

        public void CreateDataclass(CodeWriter cw, ModelInfo database, EntityInfo table, TsmDossier dossier, Pallet pallet)
        {
            CreateDataclass(cw, table, dossier);
        }

        private void CreateDataclass(CodeWriter cw, EntityInfo table, TsmDossier dossier)
        {
            cw.Empty();

            if (table.ParentEntityInfo != null)
            {
                cw.WriteLine($"export class {table.Name} extends {table.ParentEntityInfo.Name}");
            }
            else
            {
                cw.WriteLine($"export class {table.Name}");
            }

            cw.Open();

            bool first = true;
            foreach (IAttributeInfo fieldInfo in table.Attributes)
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    cw.Empty();
                }
                ITsmAttributeMold fieldMold = AttributeMolds.Create(fieldInfo);
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
        }
    }
}