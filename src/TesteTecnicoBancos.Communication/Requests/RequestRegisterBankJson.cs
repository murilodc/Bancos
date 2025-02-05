namespace TesteTecnicoBancos.Communication.Requests;
public class RequestRegisterBankJson
{
    public string Name { get; set; } = string.Empty;
    public int Code { get; set; } 
    public decimal Interest { get; set; }
}
