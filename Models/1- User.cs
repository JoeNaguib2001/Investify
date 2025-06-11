using System.ComponentModel.DataAnnotations;

namespace Investify.Models
{
    public enum UserRole
    {
        Admin,
        User
    }
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserRealName { get; set; }

        [Required]
        public string UserLoginName { get; set; }

        [Required]
        public string UserHashPassword { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public UserRole UserRole { get; set; }

        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public ICollection<Trade> Trades { get; set; } = new List<Trade>();
        public ICollection<Wallet> Wallets { get; set; } = new List<Wallet>();
    }
}
