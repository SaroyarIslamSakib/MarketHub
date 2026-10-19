using Cortex.Mediator.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketHub.Application.Features.Inventory.Commands
{
    public class AddProductCommand : ICommand<Guid>
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
