using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Investify.Migrations
{
    /// <inheritdoc />
    public partial class rapingthedatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BrokerageCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrokerageCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LastPrice = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    MonthlyPeak = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    SixMonthsPeak = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    YearPeak = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    AllTimePeak = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    Indicator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraSector = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRealName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserLoginName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserHashPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserRole = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    WalletId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    WalletName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BrokerageCompanyId = table.Column<int>(type: "int", nullable: false),
                    CommissionRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.WalletId);
                    table.ForeignKey(
                        name: "FK_Wallets_BrokerageCompanies_BrokerageCompanyId",
                        column: x => x.BrokerageCompanyId,
                        principalTable: "BrokerageCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wallets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockId = table.Column<int>(type: "int", nullable: false),
                    ProcessType = table.Column<int>(type: "int", nullable: false),
                    ProcessDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StockPrice = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    WalletId = table.Column<int>(type: "int", nullable: false),
                    BrokerageCompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trades_BrokerageCompanies_BrokerageCompanyId",
                        column: x => x.BrokerageCompanyId,
                        principalTable: "BrokerageCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trades_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trades_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trades_Wallets_WalletId",
                        column: x => x.WalletId,
                        principalTable: "Wallets",
                        principalColumn: "WalletId");
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BrokerageCompanyId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WalletId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_BrokerageCompanies_BrokerageCompanyId",
                        column: x => x.BrokerageCompanyId,
                        principalTable: "BrokerageCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Wallets_WalletId",
                        column: x => x.WalletId,
                        principalTable: "Wallets",
                        principalColumn: "WalletId");
                });

            migrationBuilder.CreateTable(
                name: "WalletStocks",
                columns: table => new
                {
                    WalletStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WalletId = table.Column<int>(type: "int", nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    BuyPricePerUnit = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    CurrentPricePerUnit = table.Column<decimal>(type: "decimal(18,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalletStocks", x => x.WalletStockId);
                    table.ForeignKey(
                        name: "FK_WalletStocks_Stocks_StockId",
                        column: x => x.StockId,
                        principalTable: "Stocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WalletStocks_Wallets_WalletId",
                        column: x => x.WalletId,
                        principalTable: "Wallets",
                        principalColumn: "WalletId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BrokerageCompanies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Thndr | ثندر" },
                    { 2, "Arabiya Online | عربية أونلاين" },
                    { 3, "Ostoul | أسطول" },
                    { 4, "Tycoon | تايكون" },
                    { 5, "Beltone | بلتون" },
                    { 6, "Mirage | ميراج" }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "AllTimePeak", "Code", "ExtraSector", "Indicator", "LastPrice", "MonthlyPeak", "Name", "Sector", "SixMonthsPeak", "YearPeak" },
                values: new object[,]
                {
                    { 1, null, "AALR", "", null, 20.000m, null, "العامة لاستصلاح الأراضي", "عقارات", null, null },
                    { 2, null, "ABUK", "أسمدة", "EGX30", 62.000m, null, "أبوقير للأسمدة", "موارد أساسية", null, null },
                    { 3, null, "ACAMD", null, null, 0.000m, null, "العربية أصول", "عقارات", null, null },
                    { 4, null, "ACAP", null, "EGX70", 2.950m, null, "ايه كابيتال القابضة", "عقارات", null, null },
                    { 5, null, "ACGC", null, "EGX70", 6.870m, null, "العربية لحليج الأقطان", "النسيج", null, null },
                    { 6, 0.000m, "ACRO", null, "", 0.000m, 0.000m, "اكرو مصر", "مقاولات و إنشاءات هندسية", 0.000m, 0.000m },
                    { 7, null, "ACTF", null, null, 0.000m, null, "أكت فاينانشال", "خدمات مالية غير مصرفية", null, null },
                    { 8, null, "ADIB", null, "EGX30", 36.980m, null, "مصرف أبو ظبي الإسلامي", "البنوك", null, null },
                    { 9, null, "ADPC", null, "EGX70", 2.400m, null, "آراب ديري باندا", "الأغذية", null, null },
                    { 10, null, "ADRI", null, null, 0.000m, null, "اراب للتنمية", "الشركات الصغيرة و المتوسطة", null, null },
                    { 11, null, "AFDI", null, "", 34.000m, 34.000m, "الأهلي للتنمية", "خدمات مالية غير مصرفية", null, null },
                    { 12, null, "AFMC", null, null, 0.000m, null, "مطاحن الإسكندرية", "الأغذية", null, null },
                    { 13, null, "AIFI", null, null, 0.790m, null, "أطلس", "عقارات", null, null },
                    { 14, null, "AIH", null, "EGX70", 0.490m, null, "ارابيا انفستمنتس هولدنج", "خدمات مالية غير مصرفية", null, null },
                    { 15, null, "AIVC", null, null, 0.000m, null, "العرفة القابضة", "منسوجات", null, null },
                    { 16, null, "AJWA", null, null, 0.000m, null, "أجواء", "الأغذية", null, null },
                    { 17, null, "ALCN", null, "EGX30", 22.800m, null, "الإسكندرية لتداول الحاويات", "خدمات النقل والشحن", null, null },
                    { 18, null, "ALEX", null, null, 0.000m, null, "الإسكندرية للأسمنت", "الأسمنت", null, null },
                    { 19, null, "ALUM", "ألمونيوم", null, 0.000m, null, "الألومنيوم العربية", "موارد أساسية", null, null },
                    { 20, 2.000m, "AMER", null, "EGX70", 1.140m, 1.150m, "عامر جروب", "عقارات", 1.500m, 1.600m },
                    { 21, null, "AMES", null, null, 0.000m, null, "المركز الطبي الجديد - الإسكندرية", "الصحة", null, null },
                    { 22, null, "AMIA", null, "EGX70", 2.410m, null, "الملتقى العربي", "المالي", null, null },
                    { 23, null, "AMOC", "", "EGX30", 8.040m, null, "أموك", "البتروكيماويات", null, null },
                    { 24, null, "ARAB", null, "EGX70", 0.340m, null, "المطورون العرب", "عقارات", null, null },
                    { 25, null, "ARCC", "أسمنت", "EGX70", 13.630m, null, "العربية للأسمنت", "مواد البناء", null, null },
                    { 26, null, "ASCM", "-", "EGX70", 37.820m, null, "أسيك للتعدين", "موارد أساسية", null, null },
                    { 27, null, "ASPI", null, null, 0.000m, null, "اسباير كابيتال", "خدمات مالية غير مصرفية", null, null },
                    { 28, null, "ASPW", null, null, 0.000m, null, "العربية وبولفارا", "منسوجات وسلع معمرة", null, null },
                    { 29, null, "ATLC", null, "EGX70", 3.900m, null, "ايه تي ليس التوفيق", "خدمات مالية غير مصرفية", null, null },
                    { 30, null, "ATQA", "حديد", "EGX70", 4.420m, null, "عتاقة", "موارد أساسية", null, null },
                    { 31, null, "BINV", null, "EGX30", 25.250m, null, "بي انفستمنتس", "خدمات مالية غير مصرفية", null, null },
                    { 32, null, "BIOC", null, null, 0.000m, null, "جلاكسو سميثكلاين", "الصحة", null, null },
                    { 33, null, "BTFH", null, "EGX30", 2.910m, null, "بلتون القابضة", "خدمات مالية غير مصرفية", null, null },
                    { 34, null, "CCAP", null, "EGX70", 2.050m, null, "القلعة", "خدمات مالية غير مصرفية", null, null },
                    { 35, null, "CERA", "سيراميك و خزف", "EGX70", 0.810m, null, "ريماس", "مواد البناء", null, null },
                    { 36, null, "CICH", null, "EGX70", 5.600m, null, "سي اي كابيتال القابضة", "خدمات مالية غير مصرفية", null, null },
                    { 37, null, "CIEB", null, "EGX30", 19.290m, null, "كريدي أجريكول", "البنوك", null, null },
                    { 38, null, "CIRA", null, null, 0.000m, null, "القاهرة للأستثمار", "المالي", null, null },
                    { 39, null, "CLHO", null, "EGX30", 8.800m, null, "مستشفى كليوباترا", "الصحة", null, null },
                    { 40, 90.000m, "COMI", "", "EGX30", 79.950m, 87.500m, "التجاري الدولي", "البنوك", 85.000m, null },
                    { 41, null, "COPR", null, null, 0.000m, null, "كوبر", "المالي", null, null },
                    { 42, null, "COSG", null, "EGX70", 0.236m, null, "القاهرة للزيوت", "الأغذية", null, null },
                    { 43, null, "CSAG", null, "EGX70", 23.050m, null, "القناة للتوكيلات", "خدمات النقل والشحن", null, null },
                    { 44, null, "DGTZ", null, "EGX70", 2.050m, null, "ديجيتايز", "الشركات الصغيرة و المتوسطة", null, null },
                    { 45, null, "DOMT", null, null, 0.000m, null, "دومتي", "الأغذية", null, null },
                    { 46, null, "DSCW", null, "EGX70", 1.600m, null, "دايس", "الملابس", null, null },
                    { 47, null, "EAST", null, "EGX30", 28.200m, null, "الشرقية للدخان", "الأغذية", null, null },
                    { 48, null, "ECAP", "سيراميك و خزف", "EGX70", 22.560m, null, "الجوهرة بورسلين", "مواد البناء", null, null },
                    { 49, null, "EEII", null, null, 1.310m, null, "العربية للصناعات الهندسية", "خدمات و منتجات صناعية و سيارات", null, null },
                    { 50, null, "EGAS", null, "EGX70", 45.025m, null, "غاز مصر", "الغاز", null, null },
                    { 51, null, "EHDR", null, "EGX70", 0.340m, null, "المصريين للإسكان", "عقارات", null, null },
                    { 52, null, "EIUD", null, "EGX70", 0.200m, null, "المصريين للإستثمار", "عقارات", null, null },
                    { 53, null, "ELEC", null, "EGX70", 2.840m, null, "الكابلات", "خدمات و منتجات صناعية و سيارات", null, null },
                    { 54, null, "ELKA", null, null, 0.000m, null, "القاهرة للإسكان", "عقارات", null, null },
                    { 55, null, "ELSH", null, "EGX70", 6.350m, null, "الشمس للإسكان", "عقارات", null, null },
                    { 56, null, "ETRS", null, "EGX70", 4.020m, null, "ايجيترانس", "خدمات النقل والشحن", null, null },
                    { 57, null, "EXPA", null, "EGX70", 15.520m, null, "بنك تنمية الصادرات", "البنوك", null, null },
                    { 58, 24.000m, "FWRY", "", "EGX30", 8.150m, 6.000m, "فوري", "اتصالات و اعلام و تكنولوجيا المعلومات", 7.000m, 6.000m },
                    { 59, null, "GBCO", null, "EGX30", 14.150m, null, "جي بي كورب", "خدمات و منتجات صناعية و سيارات", null, null },
                    { 60, null, "GIHD", null, null, 0.000m, null, "الغربية الإسلامية", "عقارات", null, null },
                    { 61, null, "HELI", null, "EGX30", 9.510m, null, "مصر الجديدة", "عقارات", null, null },
                    { 62, null, "ICFC", null, null, 0.000m, null, "الدولية للأسمدة", "البتروكيماويات", null, null },
                    { 63, null, "IEEC", null, "EGX70", 0.230m, null, "المشروعات الصناعية", "التشييد", null, null },
                    { 64, null, "INFI", null, null, 0.000m, null, "فوديكو", "الأغذية", null, null },
                    { 65, null, "ISMA", "دواجن", "EGX70", 8.260m, null, "اسماعيلية للدواجن", "الأغذية", null, null },
                    { 66, null, "ISMQ", "حديد", "EGX70", 4.250m, null, "الحديد و الصلب للمناجم و المحاجر", "موارد أساسية", null, null },
                    { 67, null, "ISPH", null, "EGX70", 5.510m, null, "ابن سينا", "الصحة", null, null },
                    { 68, null, "KZPC", "مبيدات", "EGX70", 11.000m, null, "كفر الزيات للمبيدات", "موارد أساسية", null, null },
                    { 69, null, "LCSW", "سيراميك و خزف", "EGX70", 23.270m, null, "ليسيكو", "مواد البناء", null, null },
                    { 70, null, "MASR", null, "EGX30", 0.000m, null, "مدينة نصر", "عقارات", null, null },
                    { 71, null, "MCQE", null, "EGX70", 28.300m, null, "مصر للأسمنت قنا", "الأسمنت", null, null },
                    { 72, 0.000m, "MENA", null, "EGX70", 2.070m, 0.000m, "مينا", "سياحة و ترفيه", 0.000m, 0.000m },
                    { 73, null, "MEPA", null, "EGX70", 1.250m, null, "العبوات", "الصحة", null, null },
                    { 74, null, "MFPC", "بتروكيماويات", "EGX30", 42.000m, null, "موبكو", "موارد أساسية", null, null },
                    { 75, null, "MICH", null, "EGX70", 36.000m, null, "مصر للكيماويات", "البتروكيماويات", null, null },
                    { 76, null, "MPRC", null, "EGX70", 28.510m, null, "الإنتاج الإعلامي", "اتصالات و اعلام و تكنولوجيا المعلومات", null, null },
                    { 77, null, "MTIE", null, "EGX70", 6.530m, null, "ام ام جروب", "المالي", null, null },
                    { 78, null, "NCCW", null, "EGX70", 3.850m, null, "النصر للأعمال المدنية", "التشييد", null, null },
                    { 79, null, "OLFI", null, "EGX70", 15.230m, null, "عبورلاند", "الأغذية", null, null },
                    { 80, null, "ORHD", null, "EGX70", 13.100m, null, "اوراسكوم للتنمية", "عقارات", null, null },
                    { 81, null, "ORWE", null, "EGX30", 24.670m, null, "النساجون", "النسيج", null, null },
                    { 82, null, "PHAR", null, "EGX70", 49.280m, null, "ايبيكو", "الصحة", null, null },
                    { 83, null, "PHDC", null, "EGX30", 5.900m, null, "بالم هيلز", "عقارات", null, null },
                    { 84, null, "POUL", "دواجن", "EGX70", 11.180m, null, "القاهرة للدواجن", "الأغذية", null, null },
                    { 85, null, "PRCL", "سيراميك و خزف", "EGX70", 10.890m, null, "شيني", "مواد البناء", null, null },
                    { 86, null, "PRDC", null, "EGX70", 3.270m, null, "بايونيرز بروبرتيز", "خدمات مالية غير مصرفية", null, null },
                    { 87, 0.000m, "Provider", "0", "", 0.000m, 0.000m, "السمسار", "", 0.000m, 0.000m },
                    { 88, null, "RAYA", null, "EGX70", 2.960m, null, "راية القابضة", "خدمات مالية غير مصرفية", null, null },
                    { 89, null, "RMDA", null, "EGX70", 3.620m, null, "راميدا", "الصحة", null, null },
                    { 90, null, "SDTI", null, null, 0.000m, null, "شارم دريمز", "سياحة و ترفيه", null, null },
                    { 91, null, "SPMD", null, null, 0.000m, null, "سبيد ميديكال", "الصحة", null, null },
                    { 92, null, "SUGR", null, "EGX70", 64.110m, null, "الدلتا للسكر", "الأغذية", null, null },
                    { 93, null, "SWDY", null, "EGX30", 95.000m, null, "السويدي", "خدمات و منتجات صناعية و سيارات", null, null },
                    { 94, null, "TAQA", null, "EGX70", 12.480m, null, "طاقة", "بتروكيماويات", null, null },
                    { 95, null, "TMGH", null, "EGX30", 59.980m, null, "طلعت مصطفى", "عقارات", null, null },
                    { 96, null, "UNIP", null, null, 0.000m, null, "يونيباك", "ورق و مواد تعبئة و تغليف", null, null },
                    { 97, null, "UNIT", null, null, 0.000m, null, "المتحدة للإسكان", "عقارات", null, null },
                    { 98, null, "ZMID", null, "EGX70", 7.500m, null, "زهراء المعادي", "عقارات", null, null },
                    { 99, null, "مصاريف", null, null, 0.000m, null, "خصم نقل", null, null, null },
                    { 100, null, "RREI", null, null, 1.560m, null, "اليكو", "عقارات", null, null },
                    { 101, null, "RUBX", "سيراميك و خزف", null, 7.250m, null, "روبكس", "مواد البناء", null, null },
                    { 102, null, "ADCI", null, null, 0.000m, null, "أدكو", "الصحة", null, null },
                    { 103, null, "ARVA", "محابس", null, 0.000m, null, "العربية للمحابس", "مواد البناء", null, null },
                    { 104, null, "AREH", null, null, 0.000m, null, "المجموعة المصرية العقارية", "عقارات", null, null },
                    { 106, null, "ANFI", null, null, 0.000m, null, "الإسكندرية الوطنية للإستثمارات المالية", "خدمات مالية غير مصرفية", null, null },
                    { 108, null, "BIDI", null, null, 0.000m, null, "البدر للإستثمار والتنمية", "الشركات الصغيرة والمتوسطة", null, null },
                    { 109, null, "BIGP", null, null, 0.000m, null, "بي اي جي للتجارة والاستثمار", null, null, null },
                    { 110, null, "CAED", null, null, 0.000m, null, "القاهرة للخدمات التعليمية", "خدمات تعليمية", null, null },
                    { 111, null, "CANA", null, null, 0.000m, null, "بنك قناة السويس", "البنوك", null, null },
                    { 112, null, "CNFN", null, null, 0.000m, null, "كونكت المالية القابضة", "خدمات مالية غير مصرفية", null, null },
                    { 113, null, "CPCI", null, null, 0.000m, null, "القاهرة للأدوية", "الصحة", null, null },
                    { 114, null, "EASB", null, null, 0.000m, null, "ثمار", "خدمات مالية غير مصرفية", null, null },
                    { 115, null, "EDBM", null, null, 0.000m, null, "ليفت سلاب", "مقاولات و إنشاءات هندسية", null, null },
                    { 116, null, "EFIC", "-", "EGX70", 140.010m, null, "المالية والصناعية", "موارد أساسية", null, null },
                    { 117, null, "EFID", null, "EGX30", 30.000m, null, "ايديتا", "الأغذية", null, null },
                    { 118, null, "EFIH", null, "EGX30", 20.320m, null, "اي فاينانس للاستثمارات المالية والرقمية", "اتصالات و اعلام و تكنولوجيا المعلومات", null, null },
                    { 119, null, "EGAL", "ألمونيوم", "EGX70", 113.210m, null, "مصر للألمونيوم", "موارد أساسية", null, null },
                    { 120, null, "CITI", null, null, 0.000m, null, "سيتي للتحاليل الطبية", null, null, null },
                    { 121, null, "EGTS", null, "EGX70", 5.750m, null, "المصرية للمنتجعات السياحية", "سياحة و ترفيه", null, null },
                    { 122, null, "EKHOA", null, "EGX30", 32.420m, null, "القابضة المصرية الكويتية جنيه", "خدمات مالية غير مصرفية", null, null },
                    { 123, null, "EKHO", null, "EGX30", 0.820m, null, "القابضة المصرية الكويتية دولار", "خدمات مالية غير مصرفية", null, null },
                    { 124, null, "ELNA", null, null, 0.000m, null, "النصر لتصنيع الحاصلات الزراعية", "الأغذية", null, null },
                    { 125, null, "ELWA", null, null, 0.000m, null, "الوادي العالمية", "سياحة و ترفيه", null, null },
                    { 126, null, "EMFD", null, "EGX30", 7.590m, null, "اعمار مصر", "عقارات", null, null },
                    { 127, null, "ENGC", null, "EGX70", 0.000m, null, "ايكون", "مقاولات و إنشاءات هندسية", null, null },
                    { 128, null, "EPCO", "دواجن", "EGX70", 3.970m, null, "المصرية للدواجن", "الأغذية", null, null },
                    { 129, null, "EPPL", null, null, 0.000m, null, "الأهرام للطباعة والتغليف", "ورق و مواد تعبئة و تغليف", null, null },
                    { 130, null, "ESRS", "حديد", "EGX30", 100.800m, null, "حديد عز", "موارد أساسية", null, null },
                    { 131, null, "ETEL", null, "EGX30", 33.800m, null, "المصرية للإتصالات", "اتصالات و اعلام و تكنولوجيا المعلومات", null, null },
                    { 132, null, "FAIT", null, "EGX30", 32.490m, null, "بنك فيصل الإسلامي جنيه", "البنوك", null, null },
                    { 133, null, "FIRE", null, null, 0.000m, null, "الأولي للاستثمار", "الشركات الصغيرة والمتوسطة", null, null },
                    { 134, null, "FTNS", null, null, 0.000m, null, "فتنس برايم للأندية الصحية", "الشركات الصغيرة والمتوسطة", null, null },
                    { 135, null, "GDWA", null, "EGX70", 5.080m, null, "جدوى للتنمية الصناعية", "خدمات مالية غير مصرفية", null, null },
                    { 136, null, "GGCC", null, "EGX70", 0.388m, null, "الجيزة العامة للمقاولات", "مقاولات و إنشاءات هندسية", null, null },
                    { 137, null, "GMCI", null, "", 0.000m, null, "جي إم سي", "تجارة و موزعون", null, null },
                    { 138, null, "GOCO", null, null, 0.000m, null, "جولدن كوست", "سياحة و ترفيه", null, null },
                    { 139, null, "GRCA", null, null, 0.000m, null, "جراند انفستمنت القابضة للاستثمارات المالية", "خدمات مالية غير مصرفية", null, null },
                    { 140, null, "GSSC", null, null, 0.000m, null, "العامة للصوامع والتخزين", "الأغذية", null, null },
                    { 141, null, "HDBK", null, "EGX70", 43.990m, null, "بنك التعمير والإسكان", "البنوك", null, null },
                    { 142, null, "HRHO", null, "EGX30", 23.200m, null, "اي اف جي هيرميس القابضة", "خدمات مالية غير مصرفية", null, null },
                    { 143, null, "ICID", null, null, 0.000m, null, "العالمية للاستثمار والتنمية", "عقارات", null, null },
                    { 144, null, "IDRIE", null, null, 0.000m, null, "الإسماعيلية الجديدة للتطوير", "عقارات", null, null },
                    { 145, null, "IFAP", null, "EGX70", 14.730m, null, "الدولية للمحاصيل الزراعية", "تجارة و موزعون", null, null },
                    { 146, null, "IRON", "حديد", null, 0.000m, null, "الحديد والصلب المصرية", "موارد أساسية", null, null },
                    { 147, null, "JUFO", null, "EGX30", 29.230m, null, "جهينة", "الأغذية", null, null },
                    { 148, null, "KABO", null, null, 0.000m, null, "كابو", "المنسوجات", null, null },
                    { 149, null, "KRDI", null, "EGX70", 0.510m, null, "نهر الخير للتنمية", "خدمات و منتجات صناعية و سيارات", null, null },
                    { 150, null, "LUTS", null, null, 0.000m, null, "لوتس للاستثمارات الزراعية والتنمية", "أخرى", null, null },
                    { 151, null, "MBEN", null, null, 0.000m, null, "ام بي", "الشركات الصغيرة والمتوسطة", null, null },
                    { 152, null, "MBSC", "أسمنت", null, 0.000m, null, "مصر بني سويف للأسمنت", "مواد البناء", null, null },
                    { 153, null, "MCRO", null, "EGX70", 1.800m, null, "ماكرو جروب", "الصحة", null, null },
                    { 154, null, "MFSC", null, null, 0.000m, null, "مصر للأسواق الحرة", "تجارة و موزعون", null, null },
                    { 155, null, "MHOT", null, null, 0.000m, null, "مصر للفنادق", "سياحة و ترفيه", null, null },
                    { 156, null, "MIPH", null, null, 0.000m, null, "مينا فارم للأدوية", "الصحة", null, null },
                    { 157, null, "MOED", null, null, 0.000m, null, "المصرية لنظم التعليم الحديثة", "التعليم", null, null },
                    { 158, null, "MOIL", null, "EGX70", 0.375m, null, "الخدمات الملاحية و البترولية - ماريديف", "طاقة و خدمات مساندة", null, null },
                    { 159, null, "MPCI", null, null, 0.000m, null, "ممفيس للأدوية", "الصحة", null, null },
                    { 160, null, "MPCO", "دواجن", null, 0.000m, null, "المنصورة للدواجن", "الأغذية", null, null },
                    { 161, null, "NEDA", null, null, 0.000m, null, "نيوداب", "الأغذية", null, null },
                    { 162, null, "NHPS", null, null, 0.000m, null, "الوطنية للإسكان", "عقارات", null, null },
                    { 163, null, "NINH", null, null, 0.000m, null, "مستشفى النزهة", "الصحة", null, null },
                    { 164, null, "NIPH", null, null, 0.000m, null, "النيل للأدوية", "الصحة", null, null },
                    { 165, null, "OBRI", null, null, 0.000m, null, "العبور للاستثمار العقاري", "عقارات", null, null },
                    { 166, null, "OCDI", null, "EGX70", 71.050m, null, "سوديك", "عقارات", null, null },
                    { 167, null, "OCPH", null, null, 0.000m, null, "أكتوبر فارما", "الصحة", null, null },
                    { 168, null, "ODIN", null, null, 0.000m, null, "أودن للاستثمارات المالية", "خدمات مالية غير مصرفية", null, null },
                    { 169, null, "OFH", null, "EGX70", 0.310m, null, "أوراسكوم للاستثمارات المالية القابضة", "خدمات مالية غير مصرفية", null, null },
                    { 170, null, "OIH", null, "EGX70", 0.380m, null, "أوراسكوم للاستثمار", "خدمات مالية غير مصرفية", null, null },
                    { 171, null, "ORAS", null, null, 0.000m, null, "أوراسكوم كونستراكشون", "مقاولات و إنشاءات هندسية", null, null },
                    { 172, null, "PACH", "دهانات", null, 0.000m, null, "البويات والصناعات الكيماوية", "موارد أساسية", null, null },
                    { 173, null, "PORT", null, null, 0.000m, null, "بورتو جروب", "عقارات", null, null },
                    { 174, null, "PSAD", null, null, 0.000m, null, "الصعيد العامة للمقاولات", "مقاولات و إنشاءات هندسية", null, null },
                    { 175, null, "QNBA", null, "EGX30", 31.000m, null, "بنك قطر الوطني", "البنوك", null, null },
                    { 176, null, "RACT", null, null, 0.000m, null, "ركت للتأمين", "خدمات مالية غير مصرفية", null, null },
                    { 177, null, "REAC", null, null, 0.000m, null, "ريبو للاستثمار", "خدمات مالية غير مصرفية", null, null },
                    { 178, null, "RTVC", null, "EGX70", 2.500m, null, "الرائدة للاستثمار", "عقارات", null, null },
                    { 179, null, "SAUD", null, null, 0.000m, null, "البنك السعودي المصري", "البنوك", null, null },
                    { 180, null, "SCEM", "أسمنت", null, 0.000m, null, "سيناء للأسمنت", "مواد البناء", null, null },
                    { 181, null, "SEIG", null, null, 0.000m, null, "الشرقية الوطنية للأمن الغذائي", "الأغذية", null, null },
                    { 182, null, "SIPM", null, null, 0.000m, null, "سبأ الدولية للأدوية", "الصحة", null, null },
                    { 183, null, "SKPC", null, "EGX30", 35.500m, null, "سيدي كرير", "بتروكيماويات", null, null },
                    { 184, null, "SMFR", null, null, 0.000m, null, "سامكريت", "مواد البناء", null, null },
                    { 185, null, "SNFC", null, null, 0.000m, null, "القناة للملاحة", "خدمات النقل والشحن", null, null },
                    { 186, null, "SPIN", null, null, 0.000m, null, "الإسكندرية للغزل", "النسيج", null, null },
                    { 187, null, "SRWA", null, null, 0.000m, null, "الصناعات الدوائية", "الصحة", null, null },
                    { 188, null, "STQN", null, null, 0.000m, null, "جنوب القاهرة لتوزيع الكهرباء", "طاقة و خدمات مساندة", null, null },
                    { 189, null, "SVCE", "أسمنت", "EGX70", 2.600m, null, "جنوب الوادي للأسمنت", "مواد البناء", null, null },
                    { 190, null, "TAMR", null, null, 0.000m, null, "تامر", "تجارة و موزعون", null, null },
                    { 191, null, "TORA", "أسمنت", null, 0.000m, null, "طور سيناء", "مواد البناء", null, null },
                    { 192, null, "TRTO", null, null, 0.000m, null, "النقل والسياحة", "سياحة و ترفيه", null, null },
                    { 193, null, "UCFM", null, null, 0.000m, null, "المتحدة لصناعة الأدوية", "الصحة", null, null },
                    { 194, null, "UEFM", null, null, 0.000m, null, "مطاحن مصر العليا", "الأغذية", null, null },
                    { 195, null, "UEGC", "سيراميك و خزف", null, 0.000m, null, "العامة لمنتجات الخزف", "مواد البناء", null, null },
                    { 196, null, "UNIT_", null, null, 0.000m, null, "يونيفرسال", "ورق و مواد تعبئة و تغليف", null, null },
                    { 197, null, "VAIH", null, null, 0.000m, null, "فاليو للاستثمار", "خدمات مالية غير مصرفية", null, null },
                    { 198, null, "WKOL", null, null, 0.000m, null, "وادي كوم امبو", "عقارات", null, null },
                    { 199, null, "ZEOT", null, null, 0.000m, null, "مطاحن شرق الدلتا", "الأغذية", null, null },
                    { 200, null, "EBDP", null, null, 0.000m, null, "البنك المصري لتنمية الصادرات", "البنوك", null, null },
                    { 201, null, "ELTF", null, null, 0.000m, null, "دلتا للتأمين", "خدمات مالية غير مصرفية", null, null },
                    { 202, null, "EMRI", null, null, 0.000m, null, "القاهرة الوطنية للاستثمار", "خدمات مالية غير مصرفية", null, null },
                    { 203, null, "FNAR", null, null, 0.000m, null, "الفنار", "أخرى", null, null },
                    { 204, null, "GOSO", null, null, 0.000m, null, "جولدن سول", "أخرى", null, null },
                    { 205, null, "HCFI", null, null, 0.000m, null, "العاصمة للتمويل", "خدمات مالية غير مصرفية", null, null },
                    { 206, null, "IDHC", null, null, 0.000m, null, "انترناشيونال دراجون", "أخرى", null, null },
                    { 207, null, "IDRE", null, null, 0.000m, null, "ايجيبت انترناشيونال", "عقارات", null, null },
                    { 208, null, "KWIN", null, null, 0.000m, null, "كوين سيرفس", "خدمات مالية غير مصرفية", null, null },
                    { 209, null, "MAFI", null, null, 0.000m, null, "مصر للتنمية", "خدمات مالية غير مصرفية", null, null },
                    { 210, null, "MAMD", null, null, 0.000m, null, "مصر لصناعة النشا والجلوكوز", "الأغذية", null, null },
                    { 211, null, "MILS", null, null, 0.000m, null, "مطاحن مصر الوسطى", "الأغذية", null, null },
                    { 212, null, "MMAT", null, null, 0.000m, null, "المصرية لتطوير صناعة البناء", "مقاولات و إنشاءات هندسية", null, null },
                    { 213, null, "MOIN", null, null, 0.000m, null, "المحيطات للاستثمار", "خدمات مالية غير مصرفية", null, null },
                    { 214, null, "MOPI", null, null, 0.000m, null, "المصرية للمنتجات السياحية", "سياحة و ترفيه", null, null },
                    { 215, null, "MOSC", null, null, 0.000m, null, "مصر للزيوت", "الأغذية", null, null },
                    { 216, null, "MRS", null, null, 0.000m, null, "مارسيليا", "عقارات", null, null },
                    { 217, null, "NEDA_", null, null, 0.000m, null, "النيل للمنتجات الغذائية", "الأغذية", null, null },
                    { 218, null, "NRPD", null, null, 0.000m, null, "النصر للملابس والمنسوجات", "المنسوجات", null, null },
                    { 219, null, "OBMI", null, null, 0.000m, null, "العبور للاستثمار", "خدمات مالية غير مصرفية", null, null },
                    { 220, null, "PIBD", null, null, 0.000m, null, "البحر الأحمر للتنمية", "عقارات", null, null },
                    { 221, null, "PMSI", null, null, 0.000m, null, "الدولية للصناعات الطبية", "الصحة", null, null },
                    { 222, null, "SAFA", null, null, 0.000m, null, "صفا", "خدمات مالية غير مصرفية", null, null },
                    { 223, null, "TALM", null, null, 0.000m, null, "تعمير", "عقارات", null, null },
                    { 224, null, "UTOP", null, null, 0.000m, null, "يوتوبيا", "عقارات", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "UserHashPassword", "UserLoginName", "UserRealName", "UserRole" },
                values: new object[] { 1, "youssef.naguib@example.com", "hashed_password", "youssef_naguib", "Youssef Mohsen Tharwat Naguib", 0 });

            migrationBuilder.InsertData(
                table: "Wallets",
                columns: new[] { "WalletId", "BrokerageCompanyId", "CommissionRate", "UserId", "WalletName" },
                values: new object[,]
                {
                    { 1, 4, 0.0005m, 1, "Tycoon Main Wallet" },
                    { 2, 4, 0.0005m, 1, "Tycoon Savings Wallet" }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "Amount", "BrokerageCompanyId", "Date", "Notes", "Type", "UserId", "WalletId" },
                values: new object[,]
                {
                    { 1, 1000000m, 4, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 1, 1 },
                    { 2, 1500000m, 4, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, 1, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_Code",
                table: "Stocks",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_Name",
                table: "Stocks",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trades_BrokerageCompanyId",
                table: "Trades",
                column: "BrokerageCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Trades_StockId",
                table: "Trades",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_Trades_UserId",
                table: "Trades",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Trades_WalletId",
                table: "Trades",
                column: "WalletId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_BrokerageCompanyId",
                table: "Transactions",
                column: "BrokerageCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserId",
                table: "Transactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_WalletId",
                table: "Transactions",
                column: "WalletId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_BrokerageCompanyId",
                table: "Wallets",
                column: "BrokerageCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_UserId",
                table: "Wallets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WalletStocks_StockId",
                table: "WalletStocks",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_WalletStocks_WalletId",
                table: "WalletStocks",
                column: "WalletId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trades");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "WalletStocks");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Wallets");

            migrationBuilder.DropTable(
                name: "BrokerageCompanies");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
