using CodeFirstWebAPI.Entities;

namespace CodeFirstWebAPI.Services;

public interface IUserService 
{
    List<User> GetAllUsers();
    User GetUserById(int id);
    User GetUserByName(string name);
}
public class UserService: IUserService
{
    

    private readonly IRepositoryService<User> repositoryService;

    public UserService(IRepositoryService<User> repositoryService)
    {
        this.repositoryService = repositoryService;
    }

    
    public List<User> GetAllUsers() => repositoryService.GetAll().ToList();
    public User GetUserById(int id) => repositoryService.GetById(id);
    public User GetUserByName(string name) => repositoryService.GetByName(name);

}
