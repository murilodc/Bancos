namespace TesteTecnicoBancos.Domain.Repositories;
public interface IUnitOfWork
{
    Task Commit();
}
