using AutoMapper;
using TesteTecnicoBancos.Communication.Responses;
using TesteTecnicoBancos.Domain.Repositories.Banks;

namespace TesteTecnicoBancos.Application.UseCases.Banks.Get;
public class GetAllBanksUsecase : IGetAllBanksUseCase
{
    private readonly IBanksReadOnlyRepository _repository;
    private readonly IMapper _mapper;
    public GetAllBanksUsecase(IBanksReadOnlyRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<ResponseBanksJson> Execute()
    {
        var result = await _repository.GetAll();
        return new ResponseBanksJson
        {
            Banks = _mapper.Map<List<ResponseShortBankJson>>(result),
        };
    }
}
