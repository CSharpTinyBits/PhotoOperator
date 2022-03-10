namespace PhotoOperator.Domain.Pluggins
{
    public class SliderPluggin : PlugginBase
    {
        public decimal Value { get; set; }

        public SliderPluggin(decimal value, string title) : base(title, PlugginType.Slider)
        {
            Value = value;
        }

        public override void OnApply()
        {
            throw new System.NotImplementedException();
        }
    }
}
