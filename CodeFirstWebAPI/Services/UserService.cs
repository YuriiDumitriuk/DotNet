using CodeFirstWebAPI.Entities;

namespace CodeFirstWebAPI.Services
{
    public class UserService
    {
        private static List<User> users = new List<User>
        {
            new User { Id = 1, Name = "Alice" },
            new User { Id = 2, Name = "Bob" }
        };

        public List<User> GetAllUsers() => users;

        public User GetUserById(int id) => users.FirstOrDefault(u => u.Id == id);
        public User GetUserByName(string name) => users.FirstOrDefault(u => u.Name == name);
    }
}
