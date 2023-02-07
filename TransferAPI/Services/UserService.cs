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
            try
            {
                // obs: criar classe de validação de usuários
                _userRepository.Create(user);
            }
            catch (Exception ex)
            {

                throw new TransferException("Houve um erro ao criar um novo usuário.", ex);
            }
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
            try
            {
                var userUpdated = _userRepository.Update(user);
                return userUpdated;
            }
            catch (Exception ex)
            {

                throw new TransferException("Erro ao atualizar usuário.", ex);
            }
        }
        public void DeleteUser(int id)
        {
            try
            {
                var user = GetUser(id);
                _userRepository.Delete(user);
            }
            catch (Exception ex)
            {

                throw new TransferException($"Erro ao deletar usuário com Id {id}.", ex);
            }
        }


    }
}
