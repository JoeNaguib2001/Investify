using System.ComponentModel.DataAnnotations;

namespace Investify.Models
{
    public class BrokerageCompany
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Wallet> Wallets { get; set; } = new List<Wallet>();
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public ICollection<Trade> Trades { get; set; } = new List<Trade>();

    }
}
