using System.IO;
using System.Xml.Serialization;
using Plastic.Definitions.Data;
using Plastic.Definitions.Entities;
using Plastic.Definitions.Enumerations;
using Plastic.Definitions.Views;

namespace Plastic.Definitions
{
    [XmlType("Application")]
    public class ApplicationDefinition : Definition
    {
        public ApplicationDefinition()
        {
            Enumerations = new EnumerationDefinitionCollection(this);
            Models = new ModelDefinitionCollection(this);
            Databases = new DatabaseDefinitionCollection(this);
        }

        [XmlAttribute]
        public string Namespace { get; set; }

        [XmlElement("Model")]
        public ModelDefinitionCollection Models { get; }

        [XmlElement("Database")]
        public DatabaseDefinitionCollection Databases { get; }

        [XmlElement("Enumeration")]
        public EnumerationDefinitionCollection Enumerations { get; }

        [XmlElement("UserInterface")]
        public UserInterfaceDefinitionCollection UserInterfaces { get; } = new UserInterfaceDefinitionCollection();

        public static ApplicationDefinition Load(string filename)
        {
            using (Stream stream = File.OpenRead(filename))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ApplicationDefinition));

                return serializer.Deserialize(stream) as ApplicationDefinition;
            }
        }
    }
}