using Microsoft.AspNetCore.Mvc;
using UTunes.Core;
using UTunes.Core.Entities;

namespace UTunes.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AlbumsController : ControllerBase
{
    private readonly IRepository<Album> repository;

    public AlbumsController(IRepository<Album> repository)
    {
        this.repository = repository;
    }
    [HttpGet]
    public async Task<IActionResult> GetAlbums() => Ok(await this.repository.AllAsync());
}

