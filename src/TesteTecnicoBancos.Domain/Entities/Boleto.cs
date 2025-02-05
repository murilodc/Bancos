using System.Reflection.Metadata.Ecma335;

namespace TesteTecnicoBancos.Domain.Entities;
public class Boleto
{
    public long Id { get; set; }
    public string PayeeName { get; set; } = string.Empty;
    public string PayeeCpfCnpj { get; set; } = string.Empty;
    public string RecipientName { get; set; } = string.Empty;
    public string RecipientCpfCnpj { get; set; } = string.Empty;  
    public decimal Value { get; set; }
    public DateTime DueDate { get; set; }
    public string Obs { get; set; } = string.Empty;
    public long BankId { get; set; }
    public Bank Bank { get; set; } = default!;
}
