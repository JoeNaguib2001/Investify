using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Investify.Models
{
    public class WalletStock
    {
        [Key]
        public int WalletStockId { get; set; }

        [Required]
        public int WalletId { get; set; }

        [ForeignKey(nameof(WalletId))]
        public Wallet Wallet { get; set; }

        [Required]
        public int StockId { get; set; }

        [ForeignKey(nameof(StockId))]
        public Stock Stock { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,3)")]
        public decimal BuyPricePerUnit { get; set; }

        [NotMapped]
        public decimal TotalPurchasePrice => Quantity * BuyPricePerUnit;

        [Required]
        [Column(TypeName = "decimal(18,3)")]
        public decimal CurrentPricePerUnit { get; set; }

        [NotMapped]
        public decimal TotalMarketPrice => Quantity * CurrentPricePerUnit;

        [NotMapped]
        public decimal ProfitAmount => TotalMarketPrice - TotalPurchasePrice;

        [NotMapped]
        public decimal ProfitPercentage => TotalPurchasePrice == 0 ? 0 : (ProfitAmount / TotalPurchasePrice) * 100;
    }
}
