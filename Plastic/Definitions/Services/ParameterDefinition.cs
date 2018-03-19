namespace Plastic.Definitions.Services
{
    public abstract class ParameterDefinition : Definition<OperationDefinition>
    {
        protected ParameterDefinition()
        { }

        protected ParameterDefinition(string name) : base(name)
        { }
    }

    public abstract class ParameterDefinition<T> : ParameterDefinition
    {
        protected ParameterDefinition()
        { }

        protected ParameterDefinition(string name) : base(name)
        { }
    }
}