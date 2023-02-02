using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TransferAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string FullName { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(200)]
        public string Username { get; set; }
        [MaxLength(100)]
        public string Password { get; set; }
        public Account? Account { get; set; } = new Account();
    }
}
