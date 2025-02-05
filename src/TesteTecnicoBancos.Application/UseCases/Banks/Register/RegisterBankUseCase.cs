using AutoMapper;
using TesteTecnicoBancos.Communication.Requests;
using TesteTecnicoBancos.Communication.Responses;
using TesteTecnicoBancos.Domain.Entities;
using TesteTecnicoBancos.Domain.Repositories;
using TesteTecnicoBancos.Domain.Repositories.Banks;

namespace TesteTecnicoBancos.Application.UseCases.Banks.Register;
public class RegisterBankUseCase
{
    private readonly IMapper _mapper;
    private readonly IBanksWriteOnlyRepository _repository;
    private readonly IUnitOfWork _unitOfWork;

    public RegisterBankUseCase(
        IUnitOfWork unitOfWork,
        IBanksWriteOnlyRepository repository,
        IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<ResponseRegisteredBankJson> Execute(RequestRegisterBankJson request)
    {
        var entity = _mapper.Map<Bank>(request);

        await _repository.Add(entity);
        await _unitOfWork.Commit();
        return _mapper.Map<ResponseRegisteredBankJson>(entity);
    }
}
