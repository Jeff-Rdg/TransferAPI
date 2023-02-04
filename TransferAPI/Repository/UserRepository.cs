using TransferAPI.Data;
using TransferAPI.Models;
using TransferAPI.Repository.Interfaces;

namespace TransferAPI.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(TransferContext context) : base(context)
        {
        }
    }
}
