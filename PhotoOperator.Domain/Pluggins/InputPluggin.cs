using PhotoOperator.Domain.Images;

namespace PhotoOperator.Domain.Pluggins
{
    public class InputPluggin : PlugginBase
    {
        public string Text { get; set; }

        public InputPluggin(string text, string title) : base(title, PlugginType.Input)
        {
            Text = text;
        }

        public override void OnApply(Image image)
        {
            throw new System.NotImplementedException();
        }
    }
}
