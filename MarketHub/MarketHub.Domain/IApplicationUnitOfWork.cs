using MarketHub.Domain.Repositories;

namespace MarketHub.Domain
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        public IProductRepository ProductRepository { get; }
    }
}
