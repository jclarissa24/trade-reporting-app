public interface IReportGenerator
{
    void GenerateReport(List<Trade> trades, string date);
}