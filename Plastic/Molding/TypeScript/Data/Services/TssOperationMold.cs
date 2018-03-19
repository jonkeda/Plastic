using Plastic.Infos.Services;
using Plastic.Molding.Services;

namespace Plastic.Molding.TypeScript.Data.Services
{
    public class TssOperationMold : TsMold<OperationInfo>, IOperationMold
    {
        public static TssParameterMoldCollection ParameterMolds { get; } = new TssParameterMoldCollection();

        public void CreateMethod(CodeWriter cw, ServiceInfo info, OperationInfo operationInfo, Dossier dossier)
        {
            cw.LineStart();
            cw.Write($@"{operationInfo.Name}(");


            bool first = true;
            foreach (IParameterInfo parameterInfo in operationInfo.Parameters)
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    cw.WriteLine(", ");
                    cw.LineStart();
                }
                ITssParameterMold mold = ParameterMolds.Create(parameterInfo);
                if (mold == null)
                {
                    dossier.AddError("Mold not found.", parameterInfo);
                }
                else
                {
                    mold.DoCreateParameter(parameterInfo, cw);
                }
            }
            cw.Write(")");
            string typeName = TsUtility.GetTypeName(operationInfo.ResponseEntityInfo?.Name, "models");
            if (!string.IsNullOrEmpty(typeName))
            {
                cw.Write(": ");
                cw.Write(typeName);
            }
            cw.WriteLine();

        }
    }
}