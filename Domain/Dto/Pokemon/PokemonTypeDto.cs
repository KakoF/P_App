using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Dto.Pokemon
{
    public class PokemonTypeDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
