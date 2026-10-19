using Cortex.Mediator;
using MarketHub.Application.Features.Inventory.Commands;
using MarketHub.Domain;
using MarketHub.Domain.Entities;
using MarketHub.Web.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MarketHub.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMediator _mediator;
        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IActionResult> Index()
        {
            var command = new AddProductCommand()
            {
                Name = "TV",
                Price = 5000
                
            };
            await _mediator.SendCommandAsync<AddProductCommand, Guid>(command);
            

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
