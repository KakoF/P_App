using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto.Exchange
{
    public class ExchangeResponseDto
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "traderOneId")]
        public int TraderOneId { get; set; }
        [JsonProperty(PropertyName = "traderOne")]
        public TraderResponseDto TraderOne { get; set; }
        [JsonProperty(PropertyName = "traderTwoId")]
        public int TraderTwoId { get; set; }
        [JsonProperty(PropertyName = "traderTwo")]
        public TraderResponseDto TraderTwo { get; set; }
    }
}