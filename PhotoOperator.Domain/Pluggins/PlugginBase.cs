namespace PhotoOperator.Domain.Pluggins
{
    public abstract class PlugginBase
    {
        public string Title;
        public PluginType Type;

        public PlugginBase(string title, PluginType type)
        {
            Title = title;
            Type = type;
        }
    }
}
