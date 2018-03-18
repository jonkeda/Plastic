using System.Xml.Serialization;

namespace Plastic.Definitions
{
    public abstract class Definition
    {
        protected Definition()
        {
        }

        protected Definition(string name)
        {
            Name = name;
        }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Description { get; set; }

        [XmlAttribute]
        public string DisplayName { get; set; }

    }

    public abstract class Definition<TP> : Definition
    {
        protected Definition()
        {
        }

        protected Definition(string name)
        {
            Name = name;
        }

        [XmlIgnore]
        public TP Parent { get; set; }
    }
}