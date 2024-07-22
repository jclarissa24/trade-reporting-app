using System;
using System.Collections.Generic;

public class ReportGeneratorFactory
{
    public static IReportGenerator GetReportGenerator(string productType, string broker, List<Trade> trades)
    {
        switch (productType)
        {
            case "FX Forward":
                return new FXForwardReportGenerator(broker, trades);
            case "Bond Futures":
                return new BondFuturesReportGenerator(broker, trades);
            // Other product type here
            default:
                throw new ArgumentException("No report generator found for the given product type combination.");
        }
    }
}
