namespace Backend.Models
{
    public interface IDigitalProduct : IProduct
    {
        int TotalDownloadsLeft { get; }

    }
}