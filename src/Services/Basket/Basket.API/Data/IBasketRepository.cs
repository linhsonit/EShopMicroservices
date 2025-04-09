namespace Basket.API.Data
{
    public interface IBasketRepository
    {
        Task<bool> DeleteBasketAsync(string userName, CancellationToken cancellationToken = default);
        Task<ShoppingCart> GetBasketAsync(string userName, CancellationToken cancellationToken = default);
        Task<ShoppingCart> StoreBasketAsync(ShoppingCart basket,CancellationToken cancellationToken = default);
    }
}
