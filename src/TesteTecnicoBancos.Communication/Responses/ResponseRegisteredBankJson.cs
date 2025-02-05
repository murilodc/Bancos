namespace TesteTecnicoBancos.Communication.Responses;
public class ResponseRegisteredBankJson
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Code { get; set; }
    public float Interest { get; set; }
}
