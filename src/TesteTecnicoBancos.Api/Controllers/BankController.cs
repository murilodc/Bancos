using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TesteTecnicoBancos.Application.UseCases.Banks.Get;
using TesteTecnicoBancos.Application.UseCases.Banks.Register;
using TesteTecnicoBancos.Communication.Requests;
using TesteTecnicoBancos.Communication.Responses;
using static TesteTecnicoBancos.Application.UseCases.Banks.Get.GetBankByCodeUseCase;

namespace TesteTecnicoBancos.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BankController : ControllerBase
{
    [HttpPost]
    [Authorize]
    [ProducesResponseType(typeof(ResponseRegisteredBankJson),StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Register(
        [FromServices] IRegisterBankUsecase useCase,
        [FromBody] RequestRegisterBankJson request)
    {
        var response = await useCase.Execute(request);
        return Created(string.Empty, response);
    }

    [HttpGet]
    [Authorize]
    [ProducesResponseType(typeof(ResponseBoletoJson),StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> GetAllBanks([FromServices] IGetAllBanksUseCase useCase) {
        var response = await useCase.Execute();

        if(response.Banks.Count != 0)
        {
            return Ok(response);
        }
        return NoContent();
    }

    [HttpGet]
    [Authorize]
    [Route("{code}")]
    [ProducesResponseType(typeof(ResponseBoletoJson),StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> GetByCode(
        [FromServices] IGetBankByCodeUsecase useCase,
        [FromRoute] int code)
    {
        var response = await useCase.Execute(code);
        return Ok(response);
    }
}
