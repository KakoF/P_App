using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto.Exchange
{
    public class TraderResponseDto
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "pokemons")]
        public IEnumerable<PokemonResponseDto> Pokemons { get; set; }

    }
}
