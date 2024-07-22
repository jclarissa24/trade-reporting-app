using System;
using System.Collections.Generic;

namespace TradeReportingApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string productType = args[0];
            string broker = args[1];
            string date = args.Length > 2 ? args[2] : DateTime.Now.ToString("yyyyMMdd");

            List<Trade> trades = TradeRepository.GetFilteredTrades(productType, broker, date);
            if (trades.Count == 0)
            {
                Console.WriteLine($"No trades found for {productType} trades executed by {broker} for date {date}");
                return;
            } 
            IReportGenerator reportGenerator = ReportGeneratorFactory.GetReportGenerator(productType, broker, trades);

            reportGenerator.GenerateReport(trades, date);
            Console.WriteLine($"Report generated for {productType} trades executed on {broker} for date {date}");
        }
    }
}
