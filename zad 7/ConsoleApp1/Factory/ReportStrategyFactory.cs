using System;
using ConsoleApp1.Enums;
using ConsoleApp1.Strategies;

namespace ConsoleApp1.Factory;

public class ReportStrategyFactory
{
    public IReportStrategy CreateStrategy(ReportType type)
    {
        return type switch
        {
            ReportType.Text => new TextReportStrategy(),
            ReportType.Json => new JsonReportStrategy(),
            ReportType.Csv => new CsvReportStrategy(),
            _ => throw new ArgumentException("Nieznany typ raportu", nameof(type))
        };
    }
}