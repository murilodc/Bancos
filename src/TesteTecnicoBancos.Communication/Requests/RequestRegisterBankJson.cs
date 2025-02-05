using System.ComponentModel.DataAnnotations;

namespace TesteTecnicoBancos.Communication.Requests;
public class RequestRegisterBankJson
{
    [Required(ErrorMessage = "O nome do banco é obrigatório.", AllowEmptyStrings = false)]
    public string? Name { get; set; }
    [Required(ErrorMessage = "O código do banco é obrigatório.")]
    [Range(0.01, int.MaxValue, ErrorMessage = "O código do banco deve ser maior que zero.")]
    public int Code { get; set; }
    [Required(ErrorMessage = "O percentual de juros é obrigatório.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O código do banco deve ser maior que zero.")]
    public decimal Interest { get; set; }
}
