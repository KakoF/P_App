using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto.Exchange
{
    public class PokemonResponseDto
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "pokemonId")]
        public int PokemonId { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "baseExperience")]
        public int BaseExperience { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        [JsonProperty(PropertyName = "traderId")]
        public int TraderId { get; set; }
    }
}
