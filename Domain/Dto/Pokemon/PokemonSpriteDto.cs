using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Dto.Pokemon
{
    public class PokemonSpriteDto
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }
    }
}
