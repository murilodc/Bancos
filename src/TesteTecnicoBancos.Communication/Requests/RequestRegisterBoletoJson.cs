using System.ComponentModel.DataAnnotations;

namespace TesteTecnicoBancos.Communication.Requests;
public class RequestRegisterBoletoJson
{
    [Required(ErrorMessage = "O nome do pagador é obrigatório.", AllowEmptyStrings = false)]
    public string PayeeName { get; set; } = string.Empty;

    [Required(ErrorMessage = "O CPF/CNPJ do pagador é obrigatório.", AllowEmptyStrings = false)]
    public string PayeeCpfCnpj { get; set; } = string.Empty;

    [Required(ErrorMessage = "O nome do beneficiário é obrigatório.", AllowEmptyStrings = false)]
    public string RecipientName { get; set; } = string.Empty;

    [Required(ErrorMessage = "O CPF/CNPJ do beneficiário é obrigatório.", AllowEmptyStrings = false)]
    public string RecipientCpfCnpj { get; set; } = string.Empty;

    [Required(ErrorMessage = "O valor é obrigatório.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O valor deve ser maior que zero.")]
    public decimal Value { get; set; }

    [Required(ErrorMessage = "A data de vencimento é obrigatória.")]
    public DateTime DueDate { get; set; }
    public string Obs { get; set; } = string.Empty;

    [Required(ErrorMessage = "O ID do banco é obrigatório.")]
    [Range(0.01, int.MaxValue, ErrorMessage = "O código do banco deve ser maior que zero.")]
    public long BankId { get; set; }

}
