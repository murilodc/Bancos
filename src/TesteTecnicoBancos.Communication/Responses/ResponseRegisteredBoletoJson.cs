namespace TesteTecnicoBancos.Communication.Responses;
public class ResponseRegisteredBoletoJson
{
    public string PayeeName { get; set; } = string.Empty;
    public string PayeeCpfCnpj { get; set; } = string.Empty;
    public string RecipientName { get; set; } = string.Empty;
    public string RecipientCpfCnpj { get; set; } = string.Empty;
    public float Value { get; set; }
    public DateTime Duedate { get; set; }
}
