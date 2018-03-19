using Plastic.Infos.Entities;
using Plastic.Molding.Entities;

namespace Plastic.Molding.TypeScript.Data.Models
{
    public class TsmModelMold : TsMold<ModelInfo>, IModelMold
    {
        public TsmEntityMoldCollection Attributes { get; } = new TsmEntityMoldCollection();

        public void Manufacture(TsmDossier dossier)
        {
            foreach (ModelInfo database in dossier.Info.Models)
            {
                Pallet pallet = new Pallet();
                
                // create databasecontext
                CreateModels(database, dossier, pallet);
                
                // create dataclass per table
                //CreateDataclassPerEntity(database, dossier, pallet);

                dossier.Pallets.Add(pallet);
            }

        }

        private void CreateDataclassPerEntity(ModelInfo database, TsmDossier dossier, Pallet pallet)
        {
            TsmEntityMold tableMold = new TsmEntityMold();
            foreach (EntityInfo table in database.Entities)
            {
                tableMold.CreateDataclass(database, table, dossier, pallet);
            }
        }

        private void CreateModels(ModelInfo database, TsmDossier dossier, Pallet pallet)
        {
            CodeWriter cw = new CodeWriter();

            cw.WriteLine($@"import * as enumerations from  ""Enumerations""");

            TsmEntityMold tableMold = new TsmEntityMold();

            foreach (EntityInfo table in database.Entities)
            {
                tableMold.CreateDataclass(cw, database, table, dossier, pallet);
            }

            pallet.AddProduct("TsmModel", "Models", $@"Models.ts", cw);
        }
    }
}