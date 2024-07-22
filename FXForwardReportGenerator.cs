public class FXForwardReportGenerator : BaseReportGenerator
{
    public FXForwardReportGenerator(string broker, List<Trade> trades)
        : base(broker, trades)
    {}

    protected override string GetReportFileName(string date)
    {
        return $"FXForward_{broker}_{date}.csv";
    }

    protected override string GetHeader()
    {
        return "tradeRef,productId,productName,tradeDate,qty,buySell,price";
    }

    protected override string FormatTrade(Trade trade)
    {
        return $"{trade.TradeRef},{trade.ProductId},{trade.ProductName},{trade.TradeDate},{trade.Qty},{trade.BuySell},{trade.Price}";
    }
}
