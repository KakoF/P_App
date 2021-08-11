using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto.Exchange
{
    public class ExchangeCreateDto
    {
        public TraderCreateDto TraderOne { get; set; }

        public TraderCreateDto TraderTwo { get; set; }

    }
}
