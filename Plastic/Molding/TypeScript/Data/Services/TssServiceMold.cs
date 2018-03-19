using Plastic.Infos.Services;
using Plastic.Molding.Services;

namespace Plastic.Molding.TypeScript.Data.Services
{
    public class TssServiceMold : TsMold<ServiceInfo>, IServiceInterfaceMold
    {
        public TssOperationMoldCollection Parameters { get; } = new TssOperationMoldCollection();

        public void Manufacture(TssDossier dossier)
        {
        }

        public void CreateInterfaces(CodeWriter cw, Dossier dossier, ServiceInfo info)
        {
            cw.WriteLine($@"export interface {info.Name}");

            cw.Open();

            TssOperationMold tableMold = new TssOperationMold();

            foreach (OperationInfo table in info.Operations)
            {
                tableMold.CreateMethod(cw, info, table, dossier);
            }

            cw.Close();
        }
    }
}