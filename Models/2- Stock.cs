using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Investify.Models
{
    public class Stock
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,3)")]
        public decimal? LastPrice { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal? MonthlyPeak { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal? SixMonthsPeak { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal? YearPeak { get; set; }
        [Column(TypeName = "decimal(18,3)")]
        public decimal? AllTimePeak { get; set; }
        public string? Indicator { get; set; }
        public string? Sector { get; set; }
        public string? ExtraSector { get; set; }

        // علاقات
        public virtual ICollection<Trade> Trades { get; set; } = new List<Trade>();
        public virtual ICollection<WalletStock> WalletStocks { get; set; } = new List<WalletStock>();

        [NotMapped]
        public decimal? DistanceFromMonthlyPeakPercent =>
            (LastPrice.HasValue && MonthlyPeak.HasValue && MonthlyPeak != 0)
                ? Math.Round(((MonthlyPeak.Value - LastPrice.Value) / MonthlyPeak.Value) * 100, 2)
                : 0;

        [NotMapped]
        public decimal? DistanceFromSixMonthPeakPercent =>
            (LastPrice.HasValue && SixMonthsPeak.HasValue && SixMonthsPeak != 0)
                ? Math.Round(((SixMonthsPeak.Value - LastPrice.Value) / SixMonthsPeak.Value) * 100, 2)
                : 0;

        [NotMapped]
        public decimal? DistanceFromYearPeakPercent =>
            (LastPrice.HasValue && YearPeak.HasValue && YearPeak != 0)
                ? Math.Round(((YearPeak.Value - LastPrice.Value) / YearPeak.Value) * 100, 2)
                : 0;

        [NotMapped]
        public decimal? DistanceFromAllTimePeakPercent =>
            (LastPrice.HasValue && AllTimePeak.HasValue && AllTimePeak != 0)
                ? Math.Round(((AllTimePeak.Value - LastPrice.Value) / AllTimePeak.Value) * 100, 2)
                : 0;
    }
}
