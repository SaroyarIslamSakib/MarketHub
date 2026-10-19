using MarketHub.Domain.Entities;
using MarketHub.Domain.Repositories;
using MarketHub.Infrastructure.Data;

namespace MarketHub.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product, Guid>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
