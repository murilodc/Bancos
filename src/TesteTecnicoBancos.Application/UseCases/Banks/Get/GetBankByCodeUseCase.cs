using AutoMapper;
using TesteTecnicoBancos.Communication.Responses;
using TesteTecnicoBancos.Domain.Repositories.Banks;

namespace TesteTecnicoBancos.Application.UseCases.Banks.Get;
public class GetBankByCodeUseCase : IGetBankByCodeUsecase
{
    private readonly IBanksReadOnlyRepository _repository;
    private readonly IMapper _mapper;
    public GetBankByCodeUseCase(IBanksReadOnlyRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ResponseBankJson> Execute(int code)
    {
        var result = await _repository.GetByCode(code);
        if(result == null)
        {
            throw new Exception("Nenhum banco encontrado");
        }
        return _mapper.Map<ResponseBankJson>(result);
    }
}
