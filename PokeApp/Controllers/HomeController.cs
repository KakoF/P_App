using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Domain.Dto.Exchange;
using Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PokeApp.Models;

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
        

        public async Task<IActionResult> IndexAsync()
        {
            var pokekons = await _service.GetPokemons();
            return View(pokekons);
        }

        public async Task<IActionResult> ExchangeAsync()
        {
            var exchange = await _serviceExchange.Get();
            return View(exchange);
        }

        [HttpPost]
        public async Task<IActionResult> DoExchangeAsync(ExchangeCreateDto data)
        {
            try
            {
                return Ok(await _serviceExchange.Post(data));
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }
    }
}
