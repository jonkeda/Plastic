namespace Plastic.Definitions.Services
{
    public abstract class NumberParameterDefinition<T> : ParameterDefinition<T>
        where T : struct 
    {
        protected NumberParameterDefinition()
        {
        }

        protected NumberParameterDefinition(string name) : base(name)
        {
        }
    }
}