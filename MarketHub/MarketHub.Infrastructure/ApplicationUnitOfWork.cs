using MarketHub.Domain;
using MarketHub.Domain.Repositories;
using MarketHub.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketHub.Infrastructure
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public IProductRepository ProductRepository { get; private set; }
        public ApplicationUnitOfWork(ApplicationDbContext context, IProductRepository productRepository) : base(context)
        {
            ProductRepository = productRepository;
        }
    }
}
