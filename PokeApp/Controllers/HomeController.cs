using Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PokeApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPokemonService _service;
        private readonly IExchange _serviceExchange;
        public HomeController(IPokemonService service, IExchange serviceExchange)
        {
            _service = service;
            _serviceExchange = serviceExchange;
        }


        public async Task<IActionResult> IndexAsync(int currentpage = 0)
        {
            //var pokekons = await _service.Get(0, 20);
            PaginationModel pagination = new PaginationModel(_service);
            pagination.CurrentPage = currentpage;
            await pagination.OnGetAsync();
            return View(pagination);
        }

        public async Task<IActionResult> ExchangeAsync()
        {
            var exchange = await _serviceExchange.Get();
            return View(exchange);
        }
    }
}
