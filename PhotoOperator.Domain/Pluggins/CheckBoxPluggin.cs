namespace PhotoOperator.Domain.Pluggins
{
    public class CheckBoxPluggin : PlugginBase
    {
        public bool IsEnabled { get; set; }

        public CheckBoxPluggin(bool isEnabled, string title) : base(title, PluginType.CheckBox)
        {
            IsEnabled = isEnabled;
        }
    }
}
