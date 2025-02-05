using Microsoft.AspNetCore.Mvc;

namespace TesteTecnicoBancos.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BankController : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> GetAllBanks()
    {
        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetById(
        [FromRoute] long id)
    {
        return NoContent();
    }
}
