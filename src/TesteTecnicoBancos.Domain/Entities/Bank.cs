namespace TesteTecnicoBancos.Domain.Entities;
public class Bank
{
    public long Id {  get; set; }
    public string? Name { get; set; }
    public int Code { get; set; }
    public float Interest { get; set; }
}
