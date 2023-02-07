using TransferAPI.Exceptions;
using TransferAPI.Models;
using TransferAPI.Repository.Interfaces;
using TransferAPI.Services.Interfaces;

namespace TransferAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            try
            {
                return _userRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new TransferException("Erro ao obter todos os usuários", ex);
            }
        }

        public User GetUser(int id)
        {
            try
            {
                var user = _userRepository.GetById(id);
                return user;
            }
            catch (Exception ex)
            {

                throw new TransferException($"Erro ao obter o usuário com Id {id}", ex);
            }
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }


    }
}
