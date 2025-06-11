using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Investify.Models
{
    public class Trade
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int StockId { get; set; }

        [ForeignKey(nameof(StockId))]
        public Stock Stock { get; set; }



        [Required]
        public ProcessType ProcessType { get; set; }

        [Required]
        public DateTime ProcessDateTime { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,3)")]
        public decimal StockPrice { get; set; }

        [Required]
        public int StockQuantity { get; set; }

        [NotMapped]
        public decimal StockTotalBuyPrice => StockQuantity * StockPrice;

        [NotMapped]
        public decimal? Profit
        {
            get
            {
                if (ProcessType == ProcessType.Sell)
                {
                    var walletStock = Wallet?.WalletStocks?.FirstOrDefault(ws => ws.StockId == StockId);
                    if (walletStock != null)
                        return (StockPrice - walletStock.BuyPricePerUnit) * StockQuantity;
                }
                return null;
            }
        }

        [NotMapped]
        public decimal? ProfitPercentage
        {
            get
            {
                if (Profit.HasValue && StockTotalBuyPrice > 0)
                    return (Profit.Value / StockTotalBuyPrice) * 100;
                return null;
            }
        }
        [Required]
        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [Required]
        public int WalletId { get; set; }
        [ForeignKey(nameof(WalletId))]
        public Wallet Wallet { get; set; }
        [Required]
        public int BrokerageCompanyId { get; set; } // إضافة المفتاح الأجنبي
        [ForeignKey(nameof(BrokerageCompanyId))]
        public BrokerageCompany BrokerageCompany { get; set; } // إضافة العلاقة
    }

    public enum ProcessType
    {
        Buy,
        Sell
    }
}
