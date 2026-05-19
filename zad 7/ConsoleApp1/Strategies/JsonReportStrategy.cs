using ConsoleApp1.Models;

namespace ConsoleApp1.Strategies;

public class JsonReportStrategy : IReportStrategy
{
    public string Generate(Player player)
    {
        return "{\n" +
               $"  \"Name\": \"{player.Name}\",\n" +
               $"  \"Level\": {player.Level},\n" +
               $"  \"CharacterClass\": \"{player.CharacterClass}\",\n" +
               $"  \"Gold\": {player.Gold},\n" +
               $"  \"AchievementsCount\": {player.AchievementsCount}\n" +
               "}";
    }
}