using System.Collections.Generic;

 public static class TradeRepository
{
    private static List<Trade> trades = new List<Trade>
    {
        new Trade { TradeRef = "T-FWD-1", ProductId = 1, ProductName = "AUDNZD FRD Exp14Jul2021", TradeDate = "20200408", Qty = 1000000, BuySell = "B", Price = 1.067591M, ProductType = "FX Forward", Broker = "A" },
        new Trade { TradeRef = "T-FWD-2", ProductId = 2, ProductName = "AUDUSD FRD Exp15Jul2021", TradeDate = "20200408", Qty = 8000000, BuySell = "S", Price = 0.7518301M, ProductType = "FX Forward", Broker = "B" },
        new Trade { TradeRef = "T-FWD-3", ProductId = 3, ProductName = "EURUSD FRD Exp15Jul2021", TradeDate = "20200408", Qty = 25000000, BuySell = "B", Price = 1.186073M, ProductType = "FX Forward", Broker = "A" },
        new Trade { TradeRef = "T-BF-1", ProductId = 4, ProductName = "US Treasury Bond Futures Sep2021", TradeDate = "20200408", Qty = 500, BuySell = "B", Price = 136.12M, ProductType = "Bond Futures", Broker = "A" },
        new Trade { TradeRef = "T-BF-2", ProductId = 5, ProductName = "US Treasury Bond Futures Oct2021", TradeDate = "20200408", Qty = 700, BuySell = "S", Price = 137.45M, ProductType = "Bond Futures", Broker = "B" }
        // Add more dummy trades here
    };

    public static List<Trade> GetFilteredTrades(string productType, string broker, string date)
    {
        var query = trades.Where(t => t.ProductType == productType && t.Broker == broker && t.TradeDate == date);
        return query.ToList();
    }
}

