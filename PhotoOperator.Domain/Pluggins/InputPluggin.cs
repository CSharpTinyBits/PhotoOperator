namespace PhotoOperator.Domain.Pluggins
{
    public class InputPluggin : PlugginBase
    {
        public string Text { get; set; }

        public InputPluggin(string text, string title) : base(title, PluginType.Input)
        {
            Text = text;
        }
    }
}
