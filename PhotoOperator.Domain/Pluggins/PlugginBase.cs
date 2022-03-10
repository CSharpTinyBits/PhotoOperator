namespace PhotoOperator.Domain.Pluggins
{
    public abstract class PlugginBase
    {
        public string Title;

        public PlugginBase(string title)
        {
            Title = title;
        }
    }
}
