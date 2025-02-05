using Microsoft.AspNetCore.Mvc;
using TesteTecnicoBancos.Application.UseCases.Banks.Get;
using TesteTecnicoBancos.Application.UseCases.Banks.Register;
using TesteTecnicoBancos.Communication.Requests;

namespace TesteTecnicoBancos.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BankController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Register(
        [FromServices] IRegisterBankUsecase useCase,
        [FromBody] RequestRegisterBankJson request)
    {
        var response = await useCase.Execute(request);
        return Created(string.Empty, response);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllBanks([FromServices] IGetAllBanksUseCase useCase) {
        var response = await useCase.Execute();

        if(response.Banks.Count != 0)
        {
            return Ok(response);
        }
        return NoContent();
    }

    [HttpGet]
    [Route("{code}")]
    public async Task<IActionResult> GetByCode(
        [FromServices] IGetBankByCodeUsecase useCase,
        [FromRoute] int code)
    {
        var response = await useCase.Execute(code);

        return Ok(response);
    }
}
