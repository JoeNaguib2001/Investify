using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Investify.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        public int BrokerageCompanyId { get; set; }
        public BrokerageCompany BrokerageCompany { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public TransactionType Type { get; set; }
        public string? Notes { get; set; }

        [Required]
        public int WalletId { get; set; }
        [ForeignKey(nameof(WalletId))]
        public Wallet Wallet { get; set; }
    }

    public enum TransactionType
    {
        Deposit,
        Withdrawal
    }
}
