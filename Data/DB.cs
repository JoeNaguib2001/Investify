using Investify.Models;
using Microsoft.EntityFrameworkCore;

namespace StockPortfolioApp
{
    // DbContext
    public class StockDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<BrokerageCompany> BrokerageCompanies { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Trade> Trades { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<WalletStock> WalletStocks { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public StockDbContext(DbContextOptions<StockDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new StockSeedConfiguration());

            // Unique Constraints
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<Stock>()
                .HasIndex(s => s.Code)
                .IsUnique();

            modelBuilder.Entity<Stock>()
                .HasIndex(s => s.Name)
                .IsUnique();

            // Relationships
            // User -> Wallets
            modelBuilder.Entity<User>()
                .HasMany(u => u.Wallets)
                .WithOne(w => w.User)
                .HasForeignKey(w => w.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // User -> Trades
            modelBuilder.Entity<User>()
                .HasMany(u => u.Trades)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // User -> Transactions
            modelBuilder.Entity<User>()
                .HasMany(u => u.Transactions)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // BrokerageCompany -> Wallets
            modelBuilder.Entity<BrokerageCompany>()
                .HasMany(b => b.Wallets)
                .WithOne(w => w.BrokerageCompany)
                .HasForeignKey(w => w.BrokerageCompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            // BrokerageCompany -> Trades
            modelBuilder.Entity<BrokerageCompany>()
                .HasMany(b => b.Trades)
                .WithOne(t => t.BrokerageCompany)
                .HasForeignKey(t => t.BrokerageCompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            // BrokerageCompany -> Transactions
            modelBuilder.Entity<BrokerageCompany>()
                .HasMany(b => b.Transactions)
                .WithOne(t => t.BrokerageCompany)
                .HasForeignKey(t => t.BrokerageCompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            // Stock -> Trades
            modelBuilder.Entity<Stock>()
                .HasMany(s => s.Trades)
                .WithOne(t => t.Stock)
                .HasForeignKey(t => t.StockId)
                .OnDelete(DeleteBehavior.Restrict);

            // Stock -> WalletStocks
            modelBuilder.Entity<Stock>()
                .HasMany(s => s.WalletStocks)
                .WithOne(ws => ws.Stock)
                .HasForeignKey(ws => ws.StockId)
                .OnDelete(DeleteBehavior.Restrict);

            // Wallet -> WalletStocks
            modelBuilder.Entity<Wallet>()
                .HasMany(w => w.WalletStocks)
                .WithOne(ws => ws.Wallet)
                .HasForeignKey(ws => ws.WalletId)
                .OnDelete(DeleteBehavior.Cascade);

            // Wallet -> Trades
            modelBuilder.Entity<Wallet>()
                .HasMany(w => w.Trades)
                .WithOne(t => t.Wallet)
                .HasForeignKey(t => t.WalletId)
                .OnDelete(DeleteBehavior.NoAction);

            // Wallet -> Transactions
            modelBuilder.Entity<Wallet>()
                .HasMany(w => w.Transactions)
                .WithOne(t => t.Wallet)
                .HasForeignKey(t => t.WalletId)
                .OnDelete(DeleteBehavior.NoAction);            //modelBuilder.Entity<Trade>()
            //    .HasIndex(t => new { t.WalletId, t.StockId }); modelBuilder.Entity<Transaction>()
            //            .Property(e => e.Type)
            //            .HasConversion<string>();
            modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                UserRealName = "Youssef Mohsen Tharwat Naguib",
                UserLoginName = "youssef_naguib",
                UserHashPassword = "hashed_password", // استبدل بـ Hash حقيقي لو عايز
                Email = "youssef.naguib@example.com",
                UserRole = UserRole.Admin
            }
        );

            // Seeding Brokerage Companies
            modelBuilder.Entity<BrokerageCompany>().HasData(
                new BrokerageCompany { Id = 1, Name = "Thndr | ثندر" },
                new BrokerageCompany { Id = 2, Name = "Arabiya Online | عربية أونلاين" },
                new BrokerageCompany { Id = 3, Name = "Ostoul | أسطول" },
                new BrokerageCompany { Id = 4, Name = "Tycoon | تايكون" },
                new BrokerageCompany { Id = 5, Name = "Beltone | بلتون" },
                new BrokerageCompany { Id = 6, Name = "Mirage | ميراج" }
            );

            // Seeding Wallets (محفظتين لـ Tycoon)
            modelBuilder.Entity<Wallet>().HasData(
                new Wallet
                {
                    WalletId = 1,
                    WalletName = "Tycoon Main Wallet",
                    UserId = 1,
                    BrokerageCompanyId = 4,
                    CommissionRate = 0.0005m
                },
                new Wallet
                {
                    WalletId = 2,
                    WalletName = "Tycoon Savings Wallet",
                    UserId = 1,
                    BrokerageCompanyId = 4,
                    CommissionRate = 0.0005m
                }
            );

            // Seeding Transactions (إيداعات)
            modelBuilder.Entity<Transaction>().HasData(
                new Transaction
                {
                    Id = 1,
                    UserId = 1,
                    WalletId = 1,
                    BrokerageCompanyId = 4,
                    Type = TransactionType.Deposit,
                    Amount = 1_000_000m,
                    Date = new DateTime(2025, 1, 1)
                },
                new Transaction
                {
                    Id = 2,
                    UserId = 1,
                    WalletId = 2,
                    BrokerageCompanyId = 4,
                    Type = TransactionType.Deposit,
                    Amount = 1_500_000m,
                    Date = new DateTime(2025, 1, 1)
                }
            );
        }
    }
}
