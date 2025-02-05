using Microsoft.AspNetCore.Mvc;
using TesteTecnicoBancos.Application.UseCases.Banks.Get;
using TesteTecnicoBancos.Application.UseCases.Boletos.Get;
using TesteTecnicoBancos.Application.UseCases.Boletos.Register;
using TesteTecnicoBancos.Communication.Requests;
using static TesteTecnicoBancos.Application.UseCases.Boletos.Get.GetBoletoByIdUsecase;

namespace TesteTecnicoBancos.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BoletoController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Register(
        [FromServices] IRegisterBoletoUsecase useCase,
        [FromBody] RequestRegisterBoletoJson request)
    {
        var response = await useCase.Execute(request);
        return Created(string.Empty, response);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetById(
        [FromServices] IGetBoletoByIdUseCase useCase,
        [FromRoute] long id)
    {
        try
        {
            var response = await useCase.Execute(id);
            return Ok(response);
        }
        catch (BankNotFoundException)
        {
            return NotFound("Boleto não encontrado");
        }
    }
}
