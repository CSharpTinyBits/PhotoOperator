using PhotoOperator.Domain.Images;

namespace PhotoOperator.Domain.Pluggins
{
    public abstract class PlugginBase : IPluggin
    {
        public string Title;
        public PlugginType Type;

        public PlugginBase(string title, PlugginType type)
        {
            Title = title;
            Type = type;
        }

        public abstract void OnApply(Image image);
    }
}
