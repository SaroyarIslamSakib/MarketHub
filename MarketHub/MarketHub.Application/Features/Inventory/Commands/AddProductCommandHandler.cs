using Cortex.Mediator.Commands;
using MarketHub.Domain;
using MarketHub.Domain.Entities;

namespace MarketHub.Application.Features.Inventory.Commands
{
    public class AddProductCommandHandler : ICommandHandler<AddProductCommand, Guid>
    {
        private readonly IApplicationUnitOfWork _unitOfWork;
        public AddProductCommandHandler(IApplicationUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Guid> Handle(AddProductCommand command, CancellationToken cancellationToken)
        {
            var product = new Product()
            {
                Id = new Guid(),
                Name = command.Name,
                Price = command.Price
            };

            await _unitOfWork.ProductRepository.AddAsync(product);
            await _unitOfWork.SaveAsync();
            return product.Id;
        }
    }
}
