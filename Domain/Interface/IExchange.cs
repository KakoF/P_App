using Domain.Dto;
using Domain.Dto.Exchange;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IExchange
    {
        Task<ListExchange<ExchangeResponseDto>> Get();
        Task<ExchangeResponseDto> Post(ExchangeCreateDto exchange);
    }
}
