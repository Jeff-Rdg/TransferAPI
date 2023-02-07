using TransferAPI.Models;

namespace TransferAPI.Services.Interfaces
{
    public interface IUserService
    {
        public IEnumerable<User> GetUsers();
        public User GetUser(int id);
        public User UpdateUser(User user);
        public void DeleteUser(int id);
        public void CreateUser(User user);
    }
}
