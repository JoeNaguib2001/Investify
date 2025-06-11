namespace Investify.Models.DTOS
{
    public class TradeRequestModel
    {
        public int WalletId { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public decimal ExecutionPrice { get; set; }
        public int ExecutionQuantity { get; set; }
        public ProcessType ProcessType { get; set; }

        public int BrokerageCompanyId { get; set; }
        public int UserId { get; set; }
    }
}
