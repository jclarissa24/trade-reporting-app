using System.Collections.Generic;
using System.IO;
using System.Linq;

public abstract class BaseReportGenerator : IReportGenerator
{
    protected readonly string broker;
    protected readonly List<Trade> trades;

    protected BaseReportGenerator(string broker, List<Trade> trades)
    {
        this.broker = broker;
        this.trades = trades;
    }

    public void GenerateReport(List<Trade> trades, string date)
    {
        WriteReport(trades, date);
    }

    protected virtual void WriteReport(List<Trade> filteredTrades, string date)
    {
        var reportFileName = GetReportFileName(date);
        using (var writer = new StreamWriter(reportFileName))
        {
            writer.WriteLine(GetHeader());
            foreach (var trade in filteredTrades)
            {
                writer.WriteLine(FormatTrade(trade));
            }
        }
    }

    protected abstract string GetReportFileName(string date);
    protected abstract string GetHeader();
    protected abstract string FormatTrade(Trade trade);
}
