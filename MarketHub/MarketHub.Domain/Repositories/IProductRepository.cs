using MarketHub.Domain.Entities;

namespace MarketHub.Domain.Repositories
{
    public interface IProductRepository : IRepository<Product, Guid>
    {
    }
}
