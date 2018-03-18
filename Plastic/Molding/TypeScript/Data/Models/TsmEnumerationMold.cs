using Plastic.Infos.Entities;
using Plastic.Infos.Enumerations;
using Plastic.Molding.Entities;

namespace Plastic.Molding.TypeScript.Data.Models
{
    public class TsmEnumerationMold : TsmMold<ModelInfo>, IModelMold
    {
        public TsmEntityMoldCollection Attributes { get; } = new TsmEntityMoldCollection();

        public void Manufacture(TsmDossier dossier)
        {
            foreach (EnumerationInfo enumeration in dossier.Info.Enumerations)
            {
                Pallet pallet = new Pallet();
                
                CreateEnumerations(enumeration, dossier, pallet);
                
                // create dataclass per table
                //CreateDataclassPerEntity(enumeration, dossier, pallet);

                dossier.Pallets.Add(pallet);
            }

        }

        //private void CreateEnumerationPerEntity(ModelInfo enumeration, TsmDossier dossier, Pallet pallet)
        //{
        //    TsmEntityMold tableMold = new TsmEntityMold();
        //    foreach (EntityInfo table in enumeration.Entities)
        //    {
        //        tableMold.CreateDataclass(enumeration, table, dossier, pallet);
        //    }
        //}

        private void CreateEnumerations(EnumerationInfo enumeration, TsmDossier dossier, Pallet pallet)
        {
            CodeWriter cw = new CodeWriter();

            cw.WriteLine($"export enum {enumeration.Name}");
            cw.Open();
            bool first = true;
            foreach (ValueInfo info in enumeration.Values)
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    cw.WriteLine(",");
                }
                cw.LineStart();
                cw.Write(info.Name);
            }
            cw.WriteLine();
            cw.Close();

            pallet.AddProduct("TsmEnumerations", "Models", @"Enumerations.ts", cw);
        }
    }
}