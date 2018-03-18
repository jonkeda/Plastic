using System.Xml.Serialization;
using Plastic.Definitions.Data;
using Plastic.Infos.Views;

namespace Plastic.Infos.Data
{
    public class ChildFieldInfo : EfFieldInfo<ChildFieldDefinition, string>
    {
        public ChildFieldInfo() : base("int")
        {}

        public string ChildTable { get; set; }
        [XmlIgnore]
        public TableInfo ChildTableInfo { get; set; }

        public override ControlInfo CreateControl()
        {
            return new ChildControlInfo();
        }
    }
}