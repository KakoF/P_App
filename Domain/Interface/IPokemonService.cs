﻿using Domain.Dto;
using Domain.Dto.Pokemon;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
        public interface IPokemonService
        {
            Task<PokemonDto> Get(int id);
            Task<ListResult<PokemonDto>> Get(int offset, int limit);
        }
}
