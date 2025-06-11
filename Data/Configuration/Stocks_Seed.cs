using Investify.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class StockSeedConfiguration : IEntityTypeConfiguration<Stock>
{
    public void Configure(EntityTypeBuilder<Stock> builder)
    {
        builder.HasData(
            new Stock
            {
                Id = 1,
                Code = "AALR",
                Name = "العامة لاستصلاح الأراضي",
                LastPrice = 20.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "عقارات",
                ExtraSector = ""
            },
            new Stock
            {
                Id = 2,
                Code = "ABUK",
                Name = "أبوقير للأسمدة",
                LastPrice = 62.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "موارد أساسية",
                ExtraSector = "أسمدة"
            },
            new Stock
            {
                Id = 3,
                Code = "ACAMD",
                Name = "العربية أصول",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 4,
                Code = "ACAP",
                Name = "ايه كابيتال القابضة",
                LastPrice = 2.950m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 5,
                Code = "ACGC",
                Name = "العربية لحليج الأقطان",
                LastPrice = 6.870m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "النسيج",
                ExtraSector = null
            },
            new Stock
            {
                Id = 6,
                Code = "ACRO",
                Name = "اكرو مصر",
                LastPrice = 0.000m,
                MonthlyPeak = 0.000m,
                SixMonthsPeak = 0.000m,
                YearPeak = 0.000m,
                AllTimePeak = 0.000m,
                Indicator = "",
                Sector = "مقاولات و إنشاءات هندسية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 7,
                Code = "ACTF",
                Name = "أكت فاينانشال",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 8,
                Code = "ADIB",
                Name = "مصرف أبو ظبي الإسلامي",
                LastPrice = 36.980m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "البنوك",
                ExtraSector = null
            },
            new Stock
            {
                Id = 9,
                Code = "ADPC",
                Name = "آراب ديري باندا",
                LastPrice = 2.400m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "الأغذية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 10,
                Code = "ADRI",
                Name = "اراب للتنمية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الشركات الصغيرة و المتوسطة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 11,
                Code = "AFDI",
                Name = "الأهلي للتنمية",
                LastPrice = 34.000m,
                MonthlyPeak = 34.000m,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "",
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 12,
                Code = "AFMC",
                Name = "مطاحن الإسكندرية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الأغذية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 13,
                Code = "AIFI",
                Name = "أطلس",
                LastPrice = 0.790m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 14,
                Code = "AIH",
                Name = "ارابيا انفستمنتس هولدنج",
                LastPrice = 0.490m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 15,
                Code = "AIVC",
                Name = "العرفة القابضة",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "منسوجات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 16,
                Code = "AJWA",
                Name = "أجواء",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الأغذية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 17,
                Code = "ALCN",
                Name = "الإسكندرية لتداول الحاويات",
                LastPrice = 22.800m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "خدمات النقل والشحن",
                ExtraSector = null
            },
            new Stock
            {
                Id = 18,
                Code = "ALEX",
                Name = "الإسكندرية للأسمنت",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الأسمنت",
                ExtraSector = null
            },
            new Stock
            {
                Id = 19,
                Code = "ALUM",
                Name = "الألومنيوم العربية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "موارد أساسية",
                ExtraSector = "ألمونيوم"
            },
            new Stock
            {
                Id = 20,
                Code = "AMER",
                Name = "عامر جروب",
                LastPrice = 1.140m,
                MonthlyPeak = 1.150m,
                SixMonthsPeak = 1.500m,
                YearPeak = 1.600m,
                AllTimePeak = 2.000m,
                Indicator = "EGX70",
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 21,
                Code = "AMES",
                Name = "المركز الطبي الجديد - الإسكندرية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الصحة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 22,
                Code = "AMIA",
                Name = "الملتقى العربي",
                LastPrice = 2.410m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "المالي",
                ExtraSector = null
            },
            new Stock
            {
                Id = 23,
                Code = "AMOC",
                Name = "أموك",
                LastPrice = 8.040m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "البتروكيماويات",
                ExtraSector = ""
            },
            new Stock
            {
                Id = 24,
                Code = "ARAB",
                Name = "المطورون العرب",
                LastPrice = 0.340m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 25,
                Code = "ARCC",
                Name = "العربية للأسمنت",
                LastPrice = 13.630m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "مواد البناء",
                ExtraSector = "أسمنت"
            },
            new Stock
            {
                Id = 26,
                Code = "ASCM",
                Name = "أسيك للتعدين",
                LastPrice = 37.820m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "موارد أساسية",
                ExtraSector = "-"
            },
            new Stock
            {
                Id = 27,
                Code = "ASPI",
                Name = "اسباير كابيتال",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 28,
                Code = "ASPW",
                Name = "العربية وبولفارا",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "منسوجات وسلع معمرة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 29,
                Code = "ATLC",
                Name = "ايه تي ليس التوفيق",
                LastPrice = 3.900m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 30,
                Code = "ATQA",
                Name = "عتاقة",
                LastPrice = 4.420m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "موارد أساسية",
                ExtraSector = "حديد"
            },
            new Stock
            {
                Id = 31,
                Code = "BINV",
                Name = "بي انفستمنتس",
                LastPrice = 25.250m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 32,
                Code = "BIOC",
                Name = "جلاكسو سميثكلاين",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الصحة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 33,
                Code = "BTFH",
                Name = "بلتون القابضة",
                LastPrice = 2.910m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 34,
                Code = "CCAP",
                Name = "القلعة",
                LastPrice = 2.050m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 35,
                Code = "CERA",
                Name = "ريماس",
                LastPrice = 0.810m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "مواد البناء",
                ExtraSector = "سيراميك و خزف"
            },
            new Stock
            {
                Id = 36,
                Code = "CICH",
                Name = "سي اي كابيتال القابضة",
                LastPrice = 5.600m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 37,
                Code = "CIEB",
                Name = "كريدي أجريكول",
                LastPrice = 19.290m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "البنوك",
                ExtraSector = null
            },
            new Stock
            {
                Id = 38,
                Code = "CIRA",
                Name = "القاهرة للأستثمار",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "المالي",
                ExtraSector = null
            },
            new Stock
            {
                Id = 39,
                Code = "CLHO",
                Name = "مستشفى كليوباترا",
                LastPrice = 8.800m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "الصحة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 40,
                Code = "COMI",
                Name = "التجاري الدولي",
                LastPrice = 79.950m,
                MonthlyPeak = 87.500m,
                SixMonthsPeak = 85.000m,
                YearPeak = null,
                AllTimePeak = 90.000m,
                Indicator = "EGX30",
                Sector = "البنوك",
                ExtraSector = ""
            },
            new Stock
            {
                Id = 41,
                Code = "COPR",
                Name = "كوبر",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "المالي",
                ExtraSector = null
            },
            new Stock
            {
                Id = 42,
                Code = "COSG",
                Name = "القاهرة للزيوت",
                LastPrice = 0.236m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "الأغذية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 43,
                Code = "CSAG",
                Name = "القناة للتوكيلات",
                LastPrice = 23.050m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "خدمات النقل والشحن",
                ExtraSector = null
            },
            new Stock
            {
                Id = 44,
                Code = "DGTZ",
                Name = "ديجيتايز",
                LastPrice = 2.050m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "الشركات الصغيرة و المتوسطة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 45,
                Code = "DOMT",
                Name = "دومتي",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الأغذية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 46,
                Code = "DSCW",
                Name = "دايس",
                LastPrice = 1.600m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "الملابس",
                ExtraSector = null
            },
            new Stock
            {
                Id = 47,
                Code = "EAST",
                Name = "الشرقية للدخان",
                LastPrice = 28.200m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "الأغذية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 48,
                Code = "ECAP",
                Name = "الجوهرة بورسلين",
                LastPrice = 22.560m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "مواد البناء",
                ExtraSector = "سيراميك و خزف"
            },
            new Stock
            {
                Id = 49,
                Code = "EEII",
                Name = "العربية للصناعات الهندسية",
                LastPrice = 1.310m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "خدمات و منتجات صناعية و سيارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 50,
                Code = "EGAS",
                Name = "غاز مصر",
                LastPrice = 45.025m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "الغاز",
                ExtraSector = null
            },
            new Stock
            {
                Id = 51,
                Code = "EHDR",
                Name = "المصريين للإسكان",
                LastPrice = 0.340m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 52,
                Code = "EIUD",
                Name = "المصريين للإستثمار",
                LastPrice = 0.200m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 53,
                Code = "ELEC",
                Name = "الكابلات",
                LastPrice = 2.840m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "خدمات و منتجات صناعية و سيارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 54,
                Code = "ELKA",
                Name = "القاهرة للإسكان",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 55,
                Code = "ELSH",
                Name = "الشمس للإسكان",
                LastPrice = 6.350m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 56,
                Code = "ETRS",
                Name = "ايجيترانس",
                LastPrice = 4.020m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "خدمات النقل والشحن",
                ExtraSector = null
            },
            new Stock
            {
                Id = 57,
                Code = "EXPA",
                Name = "بنك تنمية الصادرات",
                LastPrice = 15.520m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "البنوك",
                ExtraSector = null
            },
            new Stock
            {
                Id = 58,
                Code = "FWRY",
                Name = "فوري",
                LastPrice = 8.150m,
                MonthlyPeak = 6.000m,
                SixMonthsPeak = 7.000m,
                YearPeak = 6.000m,
                AllTimePeak = 24.000m,
                Indicator = "EGX30",
                Sector = "اتصالات و اعلام و تكنولوجيا المعلومات",
                ExtraSector = ""
            },
            new Stock
            {
                Id = 59,
                Code = "GBCO",
                Name = "جي بي كورب",
                LastPrice = 14.150m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "خدمات و منتجات صناعية و سيارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 60,
                Code = "GIHD",
                Name = "الغربية الإسلامية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 61,
                Code = "HELI",
                Name = "مصر الجديدة",
                LastPrice = 9.510m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 62,
                Code = "ICFC",
                Name = "الدولية للأسمدة",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "البتروكيماويات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 63,
                Code = "IEEC",
                Name = "المشروعات الصناعية",
                LastPrice = 0.230m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "التشييد",
                ExtraSector = null
            },
            new Stock
            {
                Id = 64,
                Code = "INFI",
                Name = "فوديكو",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الأغذية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 65,
                Code = "ISMA",
                Name = "اسماعيلية للدواجن",
                LastPrice = 8.260m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "الأغذية",
                ExtraSector = "دواجن"
            },
            new Stock
            {
                Id = 66,
                Code = "ISMQ",
                Name = "الحديد و الصلب للمناجم و المحاجر",
                LastPrice = 4.250m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "موارد أساسية",
                ExtraSector = "حديد"
            },
            new Stock
            {
                Id = 67,
                Code = "ISPH",
                Name = "ابن سينا",
                LastPrice = 5.510m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "الصحة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 68,
                Code = "KZPC",
                Name = "كفر الزيات للمبيدات",
                LastPrice = 11.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "موارد أساسية",
                ExtraSector = "مبيدات"
            },
            new Stock
            {
                Id = 69,
                Code = "LCSW",
                Name = "ليسيكو",
                LastPrice = 23.270m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "مواد البناء",
                ExtraSector = "سيراميك و خزف"
            },
            new Stock
            {
                Id = 70,
                Code = "MASR",
                Name = "مدينة نصر",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 71,
                Code = "MCQE",
                Name = "مصر للأسمنت قنا",
                LastPrice = 28.300m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "الأسمنت",
                ExtraSector = null
            },
            new Stock
            {
                Id = 72,
                Code = "MENA",
                Name = "مينا",
                LastPrice = 2.070m,
                MonthlyPeak = 0.000m,
                SixMonthsPeak = 0.000m,
                YearPeak = 0.000m,
                AllTimePeak = 0.000m,
                Indicator = "EGX70",
                Sector = "سياحة و ترفيه",
                ExtraSector = null
            },
            new Stock
            {
                Id = 73,
                Code = "MEPA",
                Name = "العبوات",
                LastPrice = 1.250m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "الصحة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 74,
                Code = "MFPC",
                Name = "موبكو",
                LastPrice = 42.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "موارد أساسية",
                ExtraSector = "بتروكيماويات"
            },
            new Stock
            {
                Id = 75,
                Code = "MICH",
                Name = "مصر للكيماويات",
                LastPrice = 36.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "البتروكيماويات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 76,
                Code = "MPRC",
                Name = "الإنتاج الإعلامي",
                LastPrice = 28.510m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "اتصالات و اعلام و تكنولوجيا المعلومات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 77,
                Code = "MTIE",
                Name = "ام ام جروب",
                LastPrice = 6.530m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "المالي",
                ExtraSector = null
            },
            new Stock
            {
                Id = 78,
                Code = "NCCW",
                Name = "النصر للأعمال المدنية",
                LastPrice = 3.850m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "التشييد",
                ExtraSector = null
            },
            new Stock
            {
                Id = 79,
                Code = "OLFI",
                Name = "عبورلاند",
                LastPrice = 15.230m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "الأغذية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 80,
                Code = "ORHD",
                Name = "اوراسكوم للتنمية",
                LastPrice = 13.100m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 81,
                Code = "ORWE",
                Name = "النساجون",
                LastPrice = 24.670m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "النسيج",
                ExtraSector = null
            },
            new Stock
            {
                Id = 82,
                Code = "PHAR",
                Name = "ايبيكو",
                LastPrice = 49.280m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "الصحة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 83,
                Code = "PHDC",
                Name = "بالم هيلز",
                LastPrice = 5.900m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 84,
                Code = "POUL",
                Name = "القاهرة للدواجن",
                LastPrice = 11.180m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "الأغذية",
                ExtraSector = "دواجن"
            },
            new Stock
            {
                Id = 85,
                Code = "PRCL",
                Name = "شيني",
                LastPrice = 10.890m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "مواد البناء",
                ExtraSector = "سيراميك و خزف"
            },
            new Stock
            {
                Id = 86,
                Code = "PRDC",
                Name = "بايونيرز بروبرتيز",
                LastPrice = 3.270m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 87,
                Code = "Provider",
                Name = "السمسار",
                LastPrice = 0.000m,
                MonthlyPeak = 0.000m,
                SixMonthsPeak = 0.000m,
                YearPeak = 0.000m,
                AllTimePeak = 0.000m,
                Indicator = "",
                Sector = "",
                ExtraSector = "0"
            },
            new Stock
            {
                Id = 88,
                Code = "RAYA",
                Name = "راية القابضة",
                LastPrice = 2.960m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 89,
                Code = "RMDA",
                Name = "راميدا",
                LastPrice = 3.620m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "الصحة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 90,
                Code = "SDTI",
                Name = "شارم دريمز",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "سياحة و ترفيه",
                ExtraSector = null
            },
            new Stock
            {
                Id = 91,
                Code = "SPMD",
                Name = "سبيد ميديكال",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الصحة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 92,
                Code = "SUGR",
                Name = "الدلتا للسكر",
                LastPrice = 64.110m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "الأغذية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 93,
                Code = "SWDY",
                Name = "السويدي",
                LastPrice = 95.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "خدمات و منتجات صناعية و سيارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 94,
                Code = "TAQA",
                Name = "طاقة",
                LastPrice = 12.480m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "بتروكيماويات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 95,
                Code = "TMGH",
                Name = "طلعت مصطفى",
                LastPrice = 59.980m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 96,
                Code = "UNIP",
                Name = "يونيباك",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "ورق و مواد تعبئة و تغليف",
                ExtraSector = null
            },
            new Stock
            {
                Id = 97,
                Code = "UNIT",
                Name = "المتحدة للإسكان",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 98,
                Code = "ZMID",
                Name = "زهراء المعادي",
                LastPrice = 7.500m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 99,
                Code = "مصاريف",
                Name = "خصم نقل",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = null,
                ExtraSector = null
            },
            new Stock
            {
                Id = 100,
                Code = "RREI",
                Name = "اليكو",
                LastPrice = 1.560m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 101,
                Code = "RUBX",
                Name = "روبكس",
                LastPrice = 7.250m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "مواد البناء",
                ExtraSector = "سيراميك و خزف"
            },
            new Stock
            {
                Id = 102,
                Code = "ADCI",
                Name = "أدكو",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الصحة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 103,
                Code = "ARVA",
                Name = "العربية للمحابس",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "مواد البناء",
                ExtraSector = "محابس"
            },
            new Stock
            {
                Id = 104,
                Code = "AREH",
                Name = "المجموعة المصرية العقارية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 106,
                Code = "ANFI",
                Name = "الإسكندرية الوطنية للإستثمارات المالية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 108,
                Code = "BIDI",
                Name = "البدر للإستثمار والتنمية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الشركات الصغيرة والمتوسطة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 109,
                Code = "BIGP",
                Name = "بي اي جي للتجارة والاستثمار",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = null,
                ExtraSector = null
            },
            new Stock
            {
                Id = 110,
                Code = "CAED",
                Name = "القاهرة للخدمات التعليمية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "خدمات تعليمية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 111,
                Code = "CANA",
                Name = "بنك قناة السويس",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "البنوك",
                ExtraSector = null
            },
            new Stock
            {
                Id = 112,
                Code = "CNFN",
                Name = "كونكت المالية القابضة",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 113,
                Code = "CPCI",
                Name = "القاهرة للأدوية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الصحة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 114,
                Code = "EASB",
                Name = "ثمار",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 115,
                Code = "EDBM",
                Name = "ليفت سلاب",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "مقاولات و إنشاءات هندسية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 116,
                Code = "EFIC",
                Name = "المالية والصناعية",
                LastPrice = 140.010m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "موارد أساسية",
                ExtraSector = "-"
            },
            new Stock
            {
                Id = 117,
                Code = "EFID",
                Name = "ايديتا",
                LastPrice = 30.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "الأغذية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 118,
                Code = "EFIH",
                Name = "اي فاينانس للاستثمارات المالية والرقمية",
                LastPrice = 20.320m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "اتصالات و اعلام و تكنولوجيا المعلومات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 119,
                Code = "EGAL",
                Name = "مصر للألمونيوم",
                LastPrice = 113.210m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "موارد أساسية",
                ExtraSector = "ألمونيوم"
            },
            new Stock
            {
                Id = 120,
                Code = "CITI",
                Name = "سيتي للتحاليل الطبية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = null,
                ExtraSector = null
            },
            new Stock
            {
                Id = 121,
                Code = "EGTS",
                Name = "المصرية للمنتجعات السياحية",
                LastPrice = 5.750m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "سياحة و ترفيه",
                ExtraSector = null
            },
            new Stock
            {
                Id = 122,
                Code = "EKHOA",
                Name = "القابضة المصرية الكويتية جنيه",
                LastPrice = 32.420m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 123,
                Code = "EKHO",
                Name = "القابضة المصرية الكويتية دولار",
                LastPrice = 0.820m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 124,
                Code = "ELNA",
                Name = "النصر لتصنيع الحاصلات الزراعية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الأغذية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 125,
                Code = "ELWA",
                Name = "الوادي العالمية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "سياحة و ترفيه",
                ExtraSector = null
            },
            new Stock
            {
                Id = 126,
                Code = "EMFD",
                Name = "اعمار مصر",
                LastPrice = 7.590m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 127,
                Code = "ENGC",
                Name = "ايكون",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "مقاولات و إنشاءات هندسية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 128,
                Code = "EPCO",
                Name = "المصرية للدواجن",
                LastPrice = 3.970m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "الأغذية",
                ExtraSector = "دواجن"
            },
            new Stock
            {
                Id = 129,
                Code = "EPPL",
                Name = "الأهرام للطباعة والتغليف",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "ورق و مواد تعبئة و تغليف",
                ExtraSector = null
            },
            new Stock
            {
                Id = 130,
                Code = "ESRS",
                Name = "حديد عز",
                LastPrice = 100.800m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "موارد أساسية",
                ExtraSector = "حديد"
            },
            new Stock
            {
                Id = 131,
                Code = "ETEL",
                Name = "المصرية للإتصالات",
                LastPrice = 33.800m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "اتصالات و اعلام و تكنولوجيا المعلومات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 132,
                Code = "FAIT",
                Name = "بنك فيصل الإسلامي جنيه",
                LastPrice = 32.490m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "البنوك",
                ExtraSector = null
            },
            new Stock
            {
                Id = 133,
                Code = "FIRE",
                Name = "الأولي للاستثمار",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الشركات الصغيرة والمتوسطة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 134,
                Code = "FTNS",
                Name = "فتنس برايم للأندية الصحية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الشركات الصغيرة والمتوسطة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 135,
                Code = "GDWA",
                Name = "جدوى للتنمية الصناعية",
                LastPrice = 5.080m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 136,
                Code = "GGCC",
                Name = "الجيزة العامة للمقاولات",
                LastPrice = 0.388m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "مقاولات و إنشاءات هندسية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 137,
                Code = "GMCI",
                Name = "جي إم سي",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "",
                Sector = "تجارة و موزعون",
                ExtraSector = null
            },
            new Stock
            {
                Id = 138,
                Code = "GOCO",
                Name = "جولدن كوست",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "سياحة و ترفيه",
                ExtraSector = null
            },
            new Stock
            {
                Id = 139,
                Code = "GRCA",
                Name = "جراند انفستمنت القابضة للاستثمارات المالية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 140,
                Code = "GSSC",
                Name = "العامة للصوامع والتخزين",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الأغذية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 141,
                Code = "HDBK",
                Name = "بنك التعمير والإسكان",
                LastPrice = 43.990m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "البنوك",
                ExtraSector = null
            },
            new Stock
            {
                Id = 142,
                Code = "HRHO",
                Name = "اي اف جي هيرميس القابضة",
                LastPrice = 23.200m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 143,
                Code = "ICID",
                Name = "العالمية للاستثمار والتنمية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 144,
                Code = "IDRIE",
                Name = "الإسماعيلية الجديدة للتطوير",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 145,
                Code = "IFAP",
                Name = "الدولية للمحاصيل الزراعية",
                LastPrice = 14.730m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "تجارة و موزعون",
                ExtraSector = null
            },
            new Stock
            {
                Id = 146,
                Code = "IRON",
                Name = "الحديد والصلب المصرية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "موارد أساسية",
                ExtraSector = "حديد"
            },
            new Stock
            {
                Id = 147,
                Code = "JUFO",
                Name = "جهينة",
                LastPrice = 29.230m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX30",
                Sector = "الأغذية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 148,
                Code = "KABO",
                Name = "كابو",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "المنسوجات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 149,
                Code = "KRDI",
                Name = "نهر الخير للتنمية",
                LastPrice = 0.510m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "خدمات و منتجات صناعية و سيارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 150,
                Code = "LUTS",
                Name = "لوتس للاستثمارات الزراعية والتنمية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "أخرى",
                ExtraSector = null
            },
            new Stock
            {
                Id = 151,
                Code = "MBEN",
                Name = "ام بي",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الشركات الصغيرة والمتوسطة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 152,
                Code = "MBSC",
                Name = "مصر بني سويف للأسمنت",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "مواد البناء",
                ExtraSector = "أسمنت"
            },
            new Stock
            {
                Id = 153,
                Code = "MCRO",
                Name = "ماكرو جروب",
                LastPrice = 1.800m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "الصحة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 154,
                Code = "MFSC",
                Name = "مصر للأسواق الحرة",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "تجارة و موزعون",
                ExtraSector = null
            },
            new Stock
            {
                Id = 155,
                Code = "MHOT",
                Name = "مصر للفنادق",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "سياحة و ترفيه",
                ExtraSector = null
            },
            new Stock
            {
                Id = 156,
                Code = "MIPH",
                Name = "مينا فارم للأدوية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الصحة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 157,
                Code = "MOED",
                Name = "المصرية لنظم التعليم الحديثة",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "التعليم",
                ExtraSector = null
            },
            new Stock
            {
                Id = 158,
                Code = "MOIL",
                Name = "الخدمات الملاحية و البترولية - ماريديف",
                LastPrice = 0.375m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "طاقة و خدمات مساندة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 159,
                Code = "MPCI",
                Name = "ممفيس للأدوية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الصحة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 160,
                Code = "MPCO",
                Name = "المنصورة للدواجن",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الأغذية",
                ExtraSector = "دواجن"
            },
            new Stock
            {
                Id = 161,
                Code = "NEDA",
                Name = "نيوداب",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الأغذية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 162,
                Code = "NHPS",
                Name = "الوطنية للإسكان",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 163,
                Code = "NINH",
                Name = "مستشفى النزهة",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الصحة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 164,
                Code = "NIPH",
                Name = "النيل للأدوية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الصحة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 165,
                Code = "OBRI",
                Name = "العبور للاستثمار العقاري",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 166,
                Code = "OCDI",
                Name = "سوديك",
                LastPrice = 71.050m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "عقارات",
                ExtraSector = null
            },
            new Stock
            {
                Id = 167,
                Code = "OCPH",
                Name = "أكتوبر فارما",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "الصحة",
                ExtraSector = null
            },
            new Stock
            {
                Id = 168,
                Code = "ODIN",
                Name = "أودن للاستثمارات المالية",
                LastPrice = 0.000m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = null,
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 169,
                Code = "OFH",
                Name = "أوراسكوم للاستثمارات المالية القابضة",
                LastPrice = 0.310m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            },
            new Stock
            {
                Id = 170,
                Code = "OIH",
                Name = "أوراسكوم للاستثمار",
                LastPrice = 0.380m,
                MonthlyPeak = null,
                SixMonthsPeak = null,
                YearPeak = null,
                AllTimePeak = null,
                Indicator = "EGX70",
                Sector = "خدمات مالية غير مصرفية",
                ExtraSector = null
            }
            ,
// استكمال من Id = 171
new Stock
{
    Id = 171,
    Code = "ORAS",
    Name = "أوراسكوم كونستراكشون",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "مقاولات و إنشاءات هندسية",
    ExtraSector = null
},
new Stock
{
    Id = 172,
    Code = "PACH",
    Name = "البويات والصناعات الكيماوية",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "موارد أساسية",
    ExtraSector = "دهانات"
},
new Stock
{
    Id = 173,
    Code = "PORT",
    Name = "بورتو جروب",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "عقارات",
    ExtraSector = null
},
new Stock
{
    Id = 174,
    Code = "PSAD",
    Name = "الصعيد العامة للمقاولات",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "مقاولات و إنشاءات هندسية",
    ExtraSector = null
},
new Stock
{
    Id = 175,
    Code = "QNBA",
    Name = "بنك قطر الوطني",
    LastPrice = 31.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = "EGX30",
    Sector = "البنوك",
    ExtraSector = null
},
new Stock
{
    Id = 176,
    Code = "RACT",
    Name = "ركت للتأمين",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "خدمات مالية غير مصرفية",
    ExtraSector = null
},
new Stock
{
    Id = 177,
    Code = "REAC",
    Name = "ريبو للاستثمار",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "خدمات مالية غير مصرفية",
    ExtraSector = null
},
new Stock
{
    Id = 178,
    Code = "RTVC",
    Name = "الرائدة للاستثمار",
    LastPrice = 2.500m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = "EGX70",
    Sector = "عقارات",
    ExtraSector = null
},
new Stock
{
    Id = 179,
    Code = "SAUD",
    Name = "البنك السعودي المصري",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "البنوك",
    ExtraSector = null
},
new Stock
{
    Id = 180,
    Code = "SCEM",
    Name = "سيناء للأسمنت",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "مواد البناء",
    ExtraSector = "أسمنت"
},
new Stock
{
    Id = 181,
    Code = "SEIG",
    Name = "الشرقية الوطنية للأمن الغذائي",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "الأغذية",
    ExtraSector = null
},
new Stock
{
    Id = 182,
    Code = "SIPM",
    Name = "سبأ الدولية للأدوية",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "الصحة",
    ExtraSector = null
},
new Stock
{
    Id = 183,
    Code = "SKPC",
    Name = "سيدي كرير",
    LastPrice = 35.500m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = "EGX30",
    Sector = "بتروكيماويات",
    ExtraSector = null
},
new Stock
{
    Id = 184,
    Code = "SMFR",
    Name = "سامكريت",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "مواد البناء",
    ExtraSector = null
},
new Stock
{
    Id = 185,
    Code = "SNFC",
    Name = "القناة للملاحة",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "خدمات النقل والشحن",
    ExtraSector = null
},
new Stock
{
    Id = 186,
    Code = "SPIN",
    Name = "الإسكندرية للغزل",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "النسيج",
    ExtraSector = null
},
new Stock
{
    Id = 187,
    Code = "SRWA",
    Name = "الصناعات الدوائية",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "الصحة",
    ExtraSector = null
},
new Stock
{
    Id = 188,
    Code = "STQN",
    Name = "جنوب القاهرة لتوزيع الكهرباء",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "طاقة و خدمات مساندة",
    ExtraSector = null
},
new Stock
{
    Id = 189,
    Code = "SVCE",
    Name = "جنوب الوادي للأسمنت",
    LastPrice = 2.600m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = "EGX70",
    Sector = "مواد البناء",
    ExtraSector = "أسمنت"
},
new Stock
{
    Id = 190,
    Code = "TAMR",
    Name = "تامر",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "تجارة و موزعون",
    ExtraSector = null
},
new Stock
{
    Id = 191,
    Code = "TORA",
    Name = "طور سيناء",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "مواد البناء",
    ExtraSector = "أسمنت"
},
new Stock
{
    Id = 192,
    Code = "TRTO",
    Name = "النقل والسياحة",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "سياحة و ترفيه",
    ExtraSector = null
},
new Stock
{
    Id = 193,
    Code = "UCFM",
    Name = "المتحدة لصناعة الأدوية",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "الصحة",
    ExtraSector = null
},
new Stock
{
    Id = 194,
    Code = "UEFM",
    Name = "مطاحن مصر العليا",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "الأغذية",
    ExtraSector = null
},
new Stock
{
    Id = 195,
    Code = "UEGC",
    Name = "العامة لمنتجات الخزف",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "مواد البناء",
    ExtraSector = "سيراميك و خزف"
},
new Stock
{
    Id = 196,
    Code = "UNIT_",
    Name = "يونيفرسال",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "ورق و مواد تعبئة و تغليف",
    ExtraSector = null
},
new Stock
{
    Id = 197,
    Code = "VAIH",
    Name = "فاليو للاستثمار",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "خدمات مالية غير مصرفية",
    ExtraSector = null
},
new Stock
{
    Id = 198,
    Code = "WKOL",
    Name = "وادي كوم امبو",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "عقارات",
    ExtraSector = null
},
new Stock
{
    Id = 199,
    Code = "ZEOT",
    Name = "مطاحن شرق الدلتا",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "الأغذية",
    ExtraSector = null
},
new Stock
{
    Id = 200,
    Code = "EBDP",
    Name = "البنك المصري لتنمية الصادرات",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "البنوك",
    ExtraSector = null
},
new Stock
{
    Id = 201,
    Code = "ELTF",
    Name = "دلتا للتأمين",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "خدمات مالية غير مصرفية",
    ExtraSector = null
},
new Stock
{
    Id = 202,
    Code = "EMRI",
    Name = "القاهرة الوطنية للاستثمار",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "خدمات مالية غير مصرفية",
    ExtraSector = null
},
new Stock
{
    Id = 203,
    Code = "FNAR",
    Name = "الفنار",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "أخرى",
    ExtraSector = null
},
new Stock
{
    Id = 204,
    Code = "GOSO",
    Name = "جولدن سول",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "أخرى",
    ExtraSector = null
},
new Stock
{
    Id = 205,
    Code = "HCFI",
    Name = "العاصمة للتمويل",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "خدمات مالية غير مصرفية",
    ExtraSector = null
},
new Stock
{
    Id = 206,
    Code = "IDHC",
    Name = "انترناشيونال دراجون",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "أخرى",
    ExtraSector = null
},
new Stock
{
    Id = 207,
    Code = "IDRE",
    Name = "ايجيبت انترناشيونال",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "عقارات",
    ExtraSector = null
},
new Stock
{
    Id = 208,
    Code = "KWIN",
    Name = "كوين سيرفس",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "خدمات مالية غير مصرفية",
    ExtraSector = null
},
new Stock
{
    Id = 209,
    Code = "MAFI",
    Name = "مصر للتنمية",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "خدمات مالية غير مصرفية",
    ExtraSector = null
},
new Stock
{
    Id = 210,
    Code = "MAMD",
    Name = "مصر لصناعة النشا والجلوكوز",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "الأغذية",
    ExtraSector = null
},
new Stock
{
    Id = 211,
    Code = "MILS",
    Name = "مطاحن مصر الوسطى",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "الأغذية",
    ExtraSector = null
},
new Stock
{
    Id = 212,
    Code = "MMAT",
    Name = "المصرية لتطوير صناعة البناء",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "مقاولات و إنشاءات هندسية",
    ExtraSector = null
},
new Stock
{
    Id = 213,
    Code = "MOIN",
    Name = "المحيطات للاستثمار",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "خدمات مالية غير مصرفية",
    ExtraSector = null
},
new Stock
{
    Id = 214,
    Code = "MOPI",
    Name = "المصرية للمنتجات السياحية",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "سياحة و ترفيه",
    ExtraSector = null
},
new Stock
{
    Id = 215,
    Code = "MOSC",
    Name = "مصر للزيوت",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "الأغذية",
    ExtraSector = null
},
new Stock
{
    Id = 216,
    Code = "MRS",
    Name = "مارسيليا",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "عقارات",
    ExtraSector = null
},
new Stock
{
    Id = 217,
    Code = "NEDA_",
    Name = "النيل للمنتجات الغذائية",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "الأغذية",
    ExtraSector = null
},
new Stock
{
    Id = 218,
    Code = "NRPD",
    Name = "النصر للملابس والمنسوجات",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "المنسوجات",
    ExtraSector = null
},
new Stock
{
    Id = 219,
    Code = "OBMI",
    Name = "العبور للاستثمار",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "خدمات مالية غير مصرفية",
    ExtraSector = null
},
new Stock
{
    Id = 220,
    Code = "PIBD",
    Name = "البحر الأحمر للتنمية",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "عقارات",
    ExtraSector = null
},
new Stock
{
    Id = 221,
    Code = "PMSI",
    Name = "الدولية للصناعات الطبية",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "الصحة",
    ExtraSector = null
},
new Stock
{
    Id = 222,
    Code = "SAFA",
    Name = "صفا",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "خدمات مالية غير مصرفية",
    ExtraSector = null
},
new Stock
{
    Id = 223,
    Code = "TALM",
    Name = "تعمير",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "عقارات",
    ExtraSector = null
},
new Stock
{
    Id = 224,
    Code = "UTOP",
    Name = "يوتوبيا",
    LastPrice = 0.000m,
    MonthlyPeak = null,
    SixMonthsPeak = null,
    YearPeak = null,
    AllTimePeak = null,
    Indicator = null,
    Sector = "عقارات",
    ExtraSector = null
}
            );
    }
}