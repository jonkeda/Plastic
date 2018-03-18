using Plastic.Infos.Enumerations;

namespace Plastic.Molding.Cs.Enumerations
{
    public class EnumerationMold : Mold<EnumerationInfo>, IEnumerationMold
    {
        public EnumerationMoldCollection Fields { get; } = new EnumerationMoldCollection();

        public void Manufacture(EnumerationDossier dossier)
        {
            Pallet pallet = new Pallet();
            foreach (EnumerationInfo enumeration in dossier.Info.Enumerations)
            {
               // create Enumerationcontext
               CreateEnumeration(enumeration, dossier, pallet);
            }
            dossier.Pallets.Add(pallet);
        }

        private void CreateEnumeration(EnumerationInfo enumeration, EnumerationDossier dossier, Pallet pallet)
        {
            CodeWriter cw = new CodeWriter();

            cw.WriteLine("using System.CodeDom.Compiler;");

            cw.WriteLine($"namespace {dossier.Info.Namespace}.Enumerations");
            cw.Open();

            cw.CodeCoverage();
            cw.WriteLine($"public enum {enumeration.Name}");
            cw.Open();
            foreach (ValueInfo value in enumeration.Values)
            {
                cw.WriteLine($"{value.Name},");
            }
            cw.Close();

            cw.Close();

            pallet.AddProduct("Enumeration", "Enumerations", $@"{enumeration.Name}.cs", cw);
        }
    }
}