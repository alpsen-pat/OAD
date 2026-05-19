using ConsoleApp1.Adapters;
using ConsoleApp1.Enums;
using ConsoleApp1.External;
using ConsoleApp1.Factory;
using ConsoleApp1.Models;
using ConsoleApp1.Services;

namespace ConsoleApp1.Facades;

public class ReportFacade
{
    public void GenerateAndSave(Player player, ReportType reportType)
    {
        ReportStrategyFactory factory = new ReportStrategyFactory();
        var strategy = factory.CreateStrategy(reportType);

        ReportService reportService = new ReportService(strategy);
        string reportContent = reportService.CreateReport(player);

        ExternalFileSaver externalSaver = new ExternalFileSaver();
        IReportSaver saver = new FileSaverAdapter(externalSaver);

        saver.Save(reportContent);
    }
}