using Investify.Models;
using Investify.Models.DTOS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockPortfolioApp;

namespace Investify.Controllers
{
    public class StockController : Controller
    {
        private readonly StockDbContext _context;

        public StockController(StockDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var stocks = _context.Stocks.ToList();
            return View(stocks);
        }


        // دالة لتحديث البيانات في الـ Database
        [HttpPost]
        public IActionResult UpdateStock(Stock stock)
        {
            var existingStock = _context.Stocks.FirstOrDefault(s => s.Code == stock.Code);
            if (existingStock != null)
            {
                // تحديث البيانات بناءً على الحقل المعدل
                if (!string.IsNullOrEmpty(stock.Name))
                    existingStock.Name = stock.Name;

                if (!string.IsNullOrEmpty(stock.Indicator))
                    existingStock.Indicator = stock.Indicator;

                if (stock.LastPrice > 0)
                    existingStock.LastPrice = stock.LastPrice;

                if (stock.MonthlyPeak > 0)
                    existingStock.MonthlyPeak = stock.MonthlyPeak;

                if (stock.SixMonthsPeak > 0)
                    existingStock.SixMonthsPeak = stock.SixMonthsPeak;

                if (stock.YearPeak > 0)
                    existingStock.YearPeak = stock.YearPeak;

                if (stock.AllTimePeak > 0)
                    existingStock.AllTimePeak = stock.AllTimePeak;

                if (!string.IsNullOrEmpty(stock.Sector))
                    existingStock.Sector = stock.Sector;

                if (!string.IsNullOrEmpty(stock.ExtraSector))
                    existingStock.ExtraSector = stock.ExtraSector;

                _context.SaveChanges();  // حفظ التعديلات في الـ Database
            }

            return Ok();  // الرد بنجاح
        }


        [HttpPost]
        public IActionResult ExecuteTrade(TradeRequestModel tradeRequestModel)
        {
            if (!ModelState.IsValid)
                return BadRequest("البيانات غير صالحة");

            var wallet = _context.Wallets
                .Include(w => w.WalletStocks)
                .ThenInclude(w => w.Stock)
                .Include(w => w.Transactions)
                .Include(w => w.Trades)
                .FirstOrDefault(w => w.WalletId == tradeRequestModel.WalletId && w.UserId == tradeRequestModel.UserId);

            if (wallet == null)
                return NotFound("المحفظة غير موجودة");
            var stock = _context.Stocks
                .FirstOrDefault(s => s.Code == tradeRequestModel.StockCode);
            if (tradeRequestModel.ProcessType == ProcessType.Buy)
            {
                decimal totalCost = tradeRequestModel.ExecutionPrice * tradeRequestModel.ExecutionQuantity;

                if (wallet.Balance < totalCost)
                    return BadRequest("السيولة غير كافية");

                Trade trade = new Trade()
                {
                    StockId = stock.Id,
                    ProcessType = tradeRequestModel.ProcessType,
                    ProcessDateTime = DateTime.Now,
                    WalletId = wallet.WalletId,
                    BrokerageCompanyId = tradeRequestModel.BrokerageCompanyId,
                    StockPrice = tradeRequestModel.ExecutionPrice,
                    StockQuantity = tradeRequestModel.ExecutionQuantity,
                    UserId = tradeRequestModel.UserId,
                };
                _context.Trades.Add(trade);
            }
            var existingStockInStocksWallet = wallet.WalletStocks.FirstOrDefault(s => s.Stock.Code == tradeRequestModel.StockCode);
            if (existingStockInStocksWallet != null)
            {
                var totalQty = existingStockInStocksWallet.Quantity + tradeRequestModel.ExecutionQuantity;
                existingStockInStocksWallet.BuyPricePerUnit = ((existingStockInStocksWallet.Quantity * existingStockInStocksWallet.BuyPricePerUnit) + (tradeRequestModel.ExecutionQuantity * tradeRequestModel.ExecutionPrice)) / totalQty;
                existingStockInStocksWallet.Quantity = totalQty;
            }
            else
            {
                wallet.WalletStocks.Add(new WalletStock
                {
                    StockId = stock.Id,
                    CurrentPricePerUnit = Convert.ToDecimal(stock.LastPrice),
                    Quantity = tradeRequestModel.ExecutionQuantity,
                    BuyPricePerUnit = tradeRequestModel.ExecutionPrice
                });
            }

            //else if (model.ProcessType == ProcessType.Sell)
            //{
            //    var existingStock = wallet.WalletStocks.FirstOrDefault(s => s.Stock.Code == model.StockCode);
            //    if (existingStock == null || existingStock.Quantity < model.ExecutionQuantity)
            //        return BadRequest("الكمية غير كافية للبيع");

            //    existingStock.Quantity -= model.Qty;
            //    if (existingStock.Quantity == 0)
            //        _context.Remove(existingStock);

            //    wallet.Balance += model.Price * model.Qty;
            //}
            //else
            //{
            //    return BadRequest("نوع العملية غير معروف");
            //}

            //// تسجيل العملية
            //_context.Transactions.Add(new Transaction
            //{
            //    WalletId = model.WalletId,
            //    StockCode = model.StockCode,
            //    Price = model.Price,
            //    Quantity = model.Qty,
            //    TradeType = model.TradeType,
            //    TransactionDate = DateTime.Now,
            //    UserId = model.UserId,
            //    BrokerageCompanyId = model.BrokerageCompanyId
            //});

            _context.SaveChanges();

            return Ok(new { message = "تم تنفيذ العملية بنجاح" });
        }


        [HttpGet]
        public IActionResult GetUserInfo(int userId, ProcessType processType)
        {
            // التحقق من صحة userId
            if (userId <= 0)
                return BadRequest("Invalid user ID");

            // التحقق من صحة processType
            if (processType != ProcessType.Buy && processType != ProcessType.Sell)
                return BadRequest("Invalid process type");

            // جلب اليوزر مع المحافظ
            var user = _context.Users
                .Include(u => u.Wallets)
                    .ThenInclude(w => w.BrokerageCompany) // عشان اسم الشركة
                                                          .Include(u => u.Wallets)
                                                              .ThenInclude(w => w.Transactions) // عشان Balance
                                                          .Include(u => u.Wallets)
                                                              .ThenInclude(w => w.Trades) // عشان Balance
                .Include(u => u.Wallets)
                    .ThenInclude(w => w.WalletStocks)
                        .ThenInclude(ws => ws.Stock) // عشان StockName
                .FirstOrDefault(u => u.Id == userId);

            if (user == null)
                return NotFound("User not found");

            // إعداد البيانات للإرجاع
            var walletsData = user.Wallets.Select(w => new
            {
                WalletId = w.WalletId,
                WalletName = w.WalletName,
                BrokerageCompanyName = w.BrokerageCompany?.Name,
                BrokerageCompanyId = w.BrokerageCompany?.Id,
                Balance = w.Balance,
                CommissionRate = w.CommissionRate, // إضافة العمولة
                Stocks = w.WalletStocks.Select(ws => new
                {
                    StockCode = ws.Stock.Code,
                    StockName = ws.Stock.Name,
                    Quantity = ws.Quantity,
                    AveragePrice = ws.BuyPricePerUnit
                }).ToList()
            }).ToList();

            return Ok(new
            {
                UserId = user.Id,
                UserName = user.UserRealName,
                Wallets = walletsData
            });
        }

    }
}
