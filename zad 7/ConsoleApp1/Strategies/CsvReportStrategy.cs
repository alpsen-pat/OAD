using ConsoleApp1.Models;

namespace ConsoleApp1.Strategies;

public class CsvReportStrategy : IReportStrategy
{
    public string Generate(Player player)
    {
        return "Name;Level;CharacterClass;Gold;AchievementsCount\n" +
               $"{player.Name};{player.Level};{player.CharacterClass};{player.Gold};{player.AchievementsCount}";
    }
}