using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto.Exchange
{
    public class TraderResponseDto
    {
        public string Name { get; set; }
        public IEnumerable<PokemonResponseDto> Pokemons { get; set; }

    }
}
