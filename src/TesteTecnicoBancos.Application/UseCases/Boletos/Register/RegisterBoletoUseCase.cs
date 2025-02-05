using AutoMapper;
using TesteTecnicoBancos.Communication.Requests;
using TesteTecnicoBancos.Communication.Responses;
using TesteTecnicoBancos.Domain.Entities;
using TesteTecnicoBancos.Domain.Repositories;
using TesteTecnicoBancos.Domain.Repositories.Boletos;

namespace TesteTecnicoBancos.Application.UseCases.Boletos.Register;
public class RegisterBoletoUseCase : IRegisterBoletoUsecase
{
    private readonly IMapper _mapper;
    private readonly IBoletosWriteOnlyRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public RegisterBoletoUseCase(IMapper mapper, IBoletosWriteOnlyRepository repository, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _repository = repository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ResponseRegisteredBoletoJson> Execute(RequestRegisterBoletoJson request)
    {
        var entity = _mapper.Map<Boleto>(request);

        await _repository.Add(entity);
        await _unitOfWork.Commit();
        return _mapper.Map<ResponseRegisteredBoletoJson>(entity);
    }
}
