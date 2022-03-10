using System;


namespace PhotoOperator.Domain.Images
{
    public class Image
    {
        public Guid Id { get; }
        public byte[] Content { get; }
    }
}
