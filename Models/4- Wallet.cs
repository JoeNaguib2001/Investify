using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Investify.Models
{
    public class Wallet
    {
        [Key]
        public int WalletId { get; set; }

        [Required]
        public int UserId { get; set; }



        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [Required]
        [MaxLength(100)]
        public string WalletName { get; set; }

        [Required]
        public int BrokerageCompanyId { get; set; }

        [ForeignKey(nameof(BrokerageCompanyId))]
        public BrokerageCompany BrokerageCompany { get; set; }

        public ICollection<WalletStock> WalletStocks { get; set; } = new List<WalletStock>();
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public ICollection<Trade> Trades { get; set; } = new List<Trade>();
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal CommissionRate { get; set; } = 0;

        [NotMapped]
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                // حساب الإيداعات والسحوبات
                foreach (var transaction in Transactions ?? new List<Transaction>())
                {
                    if (transaction.Type == TransactionType.Deposit)
                        balance += transaction.Amount;
                    else if (transaction.Type == TransactionType.Withdrawal)
                        balance -= transaction.Amount;
                }
                // حساب عمليات الشراء والبيع
                foreach (var trade in Trades ?? new List<Trade>())
                {
                    if (trade.ProcessType == ProcessType.Buy)
                        balance -= trade.StockTotalBuyPrice;
                    else if (trade.ProcessType == ProcessType.Sell)
                        balance += trade.StockTotalBuyPrice;
                }
                return balance;
            }
        }

    }
}
