using ConsoleApp1.Models;
using ConsoleApp1.Strategies;

namespace ConsoleApp1.Services;

public class ReportService
{
    private readonly IReportStrategy _strategy;

    public ReportService(IReportStrategy strategy)
    {
        _strategy = strategy;
    }

    public string CreateReport(Player player)
    {
        return _strategy.Generate(player);
    }
}