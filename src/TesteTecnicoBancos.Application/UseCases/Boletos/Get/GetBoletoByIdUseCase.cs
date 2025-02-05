using AutoMapper;
using TesteTecnicoBancos.Application.UseCases.Banks.Get;
using TesteTecnicoBancos.Communication.Responses;
using TesteTecnicoBancos.Domain.Entities;
using TesteTecnicoBancos.Domain.Repositories.Banks;
using TesteTecnicoBancos.Domain.Repositories.Boletos;

namespace TesteTecnicoBancos.Application.UseCases.Boletos.Get;
public class GetBoletoByIdUsecase : IGetBoletoByIdUseCase
{
    private readonly IMapper _mapper;
    private readonly IBoletosReadOnlyRepository _repository;
    private readonly IBanksReadOnlyRepository _bankrepository;
    
    public GetBoletoByIdUsecase(IMapper mapper, IBoletosReadOnlyRepository repository, IBanksReadOnlyRepository bankRepository)
    {
        _mapper = mapper;
        _repository = repository;
        _bankrepository = bankRepository;
    }
    public async Task<ResponseBoletoJson> Execute(long id)
    {
        var result = await _repository.GetById(id);
        if(result != null)
        {
            result.Value = await CalculateFinalValue(result);
        }

        return _mapper.Map<ResponseBoletoJson>(result);
    }
    private async Task<decimal> CalculateFinalValue(Boleto boleto)
    {
        var bank = await _bankrepository.GetByBankId(boleto.BankId);
        if(bank != null)
        {
            DateTime today = DateTime.Today;
            if (today > boleto.DueDate)
            {
                int days = (today - boleto.DueDate).Days;
                decimal interest = boleto.Value * (bank.Interest / 100) * days;
                return boleto.Value + interest;
            }
        }
        return boleto.Value;
    }

}
