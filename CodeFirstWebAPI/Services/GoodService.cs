using CodeFirstWebAPI.Entities;
using System.Security.Cryptography.X509Certificates;

namespace CodeFirstWebAPI.Services;
public interface IGoodService
{
    List<Good> GetAllGoods();
    Good GetGoodById(int id);
    Good GetGoodByName(string name);
}

public class GoodService : IGoodService
{
    

    private readonly IRepositoryService<Good> repositoryService;

    public GoodService(IRepositoryService<Good> repositoryService)
    {
        this.repositoryService = repositoryService;
    }

    public List<Good> GetAllGoods() => repositoryService.GetAll().ToList();
    public Good GetGoodById(int id) => repositoryService.GetById(id);
    public Good GetGoodByName(string name)=> repositoryService.GetByName(name);
}
