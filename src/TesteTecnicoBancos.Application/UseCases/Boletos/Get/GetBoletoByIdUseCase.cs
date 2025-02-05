using AutoMapper;
using TesteTecnicoBancos.Communication.Responses;
using TesteTecnicoBancos.Domain.Repositories.Boletos;

namespace TesteTecnicoBancos.Application.UseCases.Boletos.Get;
public class GetBoletoByIdUsecase : IGetBoletoByIdUseCase
{
    private readonly IMapper _mapper;
    private readonly IBoletosReadOnlyRepository _repository;
    
    public GetBoletoByIdUsecase(IMapper mapper, IBoletosReadOnlyRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }
    public async Task<ResponseBoletoJson> Execute(long id)
    {
        var result = await _repository.GetById(id);
        if(result == null)
        {
            throw new Exception("Nenhum boleto encontrado");
        }
        return _mapper.Map<ResponseBoletoJson>(result);
    }
}
