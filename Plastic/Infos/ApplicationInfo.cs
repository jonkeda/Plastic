using Plastic.Definitions;
using Plastic.Infos.Data;
using Plastic.Infos.Entities;
using Plastic.Infos.Services;
using Plastic.Infos.Views;

namespace Plastic.Infos
{
    public class ApplicationInfo : Info<ApplicationDefinition>
    {
        public ApplicationInfo()
        {
            Services = new ServiceInfoCollection(this);
            Models = new ModelInfoCollection(this);
            UserInterfaces = new UserInterfaceInfoCollection(this);
            Enumerations = new EnumerationInfoCollection(this);
            Databases = new DatabaseInfoCollection(this);
        }

        public ServiceInfoCollection Services { get; }
        public ModelInfoCollection Models { get; }
        public DatabaseInfoCollection Databases { get; }
        public EnumerationInfoCollection Enumerations { get; }
        public UserInterfaceInfoCollection UserInterfaces { get; }

        public string Namespace { get; set; }

        protected override void OnSet(ApplicationDefinition definition)
        {
            Namespace = definition.Namespace;

            Enumerations.Set(definition.Enumerations);

            Models.Set(definition.Models);
            Models.SetRef(this);
            Models.SetAdd(this);

            Databases.Set(definition.Databases);
            Databases.SetRef(this);
            Databases.SetAdd(this);

            Services.Set(definition.Services);
            Services.SetRef(this);
            Services.SetAdd(this);

            UserInterfaces.Set(definition.UserInterfaces);

            Models.OrderEntities();
        }
    }
}