using PhotoOperator.Domain.Images;

namespace PhotoOperator.Domain.Pluggins
{
    interface IPluggin
    {
        void OnApply(Image image);
    }
}
