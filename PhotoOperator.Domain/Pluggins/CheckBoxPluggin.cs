using PhotoOperator.Domain.Images;

namespace PhotoOperator.Domain.Pluggins
{
    public class CheckBoxPluggin : PlugginBase
    {
        public bool IsEnabled { get; set; }

        public CheckBoxPluggin(bool isEnabled, string title) : base(title, PlugginType.CheckBox)
        {
            IsEnabled = isEnabled;
        }

        public override void OnApply(Image image)
        {
            throw new System.NotImplementedException();
        }
    }
}
