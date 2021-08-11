using Domain.Dto;
using Domain.Dto.Pokemon;
using Domain.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading.Tasks;

public class PaginationModel : PageModel
{
    private readonly IPokemonService _service;

    public PaginationModel(IPokemonService service)
    {
        _service = service;
    }

    [BindProperty(SupportsGet = true)]
    public int CurrentPage { get; set; } = 0;
    public int Count { get; set; }
    public int PageSize { get; set; } = 10;

    public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));

    public ListResult<PokemonDto> Data { get; set; }

    public bool ShowPrevious => CurrentPage > 1;
    public bool ShowNext => CurrentPage < TotalPages;

    public async Task OnGetAsync()
    {
        Data = await _service.Get(CurrentPage * 10, PageSize);
        Count = int.Parse(Data.Data.Count.ToString());
    }
}