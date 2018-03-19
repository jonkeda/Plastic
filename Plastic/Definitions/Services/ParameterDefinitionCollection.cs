namespace Plastic.Definitions.Services
{
    public class ParameterDefinitionCollection : DefinitionCollection<ParameterDefinition, OperationDefinition>
    {
        public ParameterDefinitionCollection(OperationDefinition parent) : base(parent)
        {
        }
    }
}