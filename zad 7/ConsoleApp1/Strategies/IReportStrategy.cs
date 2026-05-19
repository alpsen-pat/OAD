using ConsoleApp1.Models;

namespace ConsoleApp1.Strategies;

public interface IReportStrategy
{
    string Generate(Player player);
}