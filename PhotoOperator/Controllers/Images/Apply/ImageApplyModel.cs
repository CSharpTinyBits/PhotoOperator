using PhotoOperator.Domain.Pluggins;

namespace PhotoOperator.Controllers.Apply
{
    public class ImageApplyModel
    {
        public string ImagePath { get; set; }
        public PlugginBase[] AppliedPluggins { get; set; }
    }
}