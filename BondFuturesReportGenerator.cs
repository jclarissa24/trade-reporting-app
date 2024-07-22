public class BondFuturesReportGenerator : BaseReportGenerator
{
    public BondFuturesReportGenerator(string broker, List<Trade> trades) 
        : base(broker, trades)
    {}

    protected override string GetReportFileName(string date)
    {
        return $"BondFutures_{broker}_{date}.csv";
    }

    protected override string GetHeader()
    {
        return "productId,tradeRef,productName,tradeDate,qty,buySell,price";
    }

    protected override string FormatTrade(Trade trade)
    {
        return $"{trade.ProductId},{trade.TradeRef},{trade.ProductName},{trade.TradeDate},{trade.Qty},{trade.BuySell},{trade.Price}";
    }
}
