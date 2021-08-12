using Domain.Dto;
using Domain.Dto.Exchange;
using Domain.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class Exchange : IExchange
    {
        private readonly IHttpRequest _request;
        public Exchange(IHttpRequest request)
        {
            _request = request;
        }

        public async Task<ListExchange<ExchangeResponseDto>> Get()
        {
            var data = await _request.GetRequest("exchange");
            return JsonConvert.DeserializeObject<ListExchange<ExchangeResponseDto>>(data);
        }

        public async Task<ListResult<ExchangeResponseDto>> Post(ExchangeCreateDto exchange)
        {
                var data = await _request.PostRequest("exchange", exchange);
                return JsonConvert.DeserializeObject<ListResult<ExchangeResponseDto>>(data);
        }
    }
}
