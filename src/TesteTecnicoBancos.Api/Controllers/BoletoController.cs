using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TesteTecnicoBancos.Application.UseCases.Banks.Get;
using TesteTecnicoBancos.Application.UseCases.Boletos.Get;
using TesteTecnicoBancos.Application.UseCases.Boletos.Register;
using TesteTecnicoBancos.Communication.Requests;
using TesteTecnicoBancos.Communication.Responses;
using static TesteTecnicoBancos.Application.UseCases.Boletos.Get.GetBoletoByIdUsecase;

namespace TesteTecnicoBancos.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BoletoController : ControllerBase
{
    [HttpPost]
    [Authorize]
    [ProducesResponseType(typeof(ResponseRegisteredBoletoJson),StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Register(
        [FromServices] IRegisterBoletoUsecase useCase,
        [FromBody] RequestRegisterBoletoJson request)
    {
        var response = await useCase.Execute(request);
        return Created(string.Empty, response);
    }

    [HttpGet]
    [Route("{id}")]
    [Authorize]
    [ProducesResponseType(typeof(ResponseBoletoJson),StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> GetById(
        [FromServices] IGetBoletoByIdUseCase useCase,
        [FromRoute] long id)
    {
        var response = await useCase.Execute(id);
        return Ok(response);
    }
}
