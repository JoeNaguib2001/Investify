namespace Investify.Models.DTOS
{
    public class StocksBrokerageCompaniesDTO
    {
        public IEnumerable<Stock> Stocks { get; set; }
        public IEnumerable<BrokerageCompany> BrokerageCompanies { get; set; }
    }
}
