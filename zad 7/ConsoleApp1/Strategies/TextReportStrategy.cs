using ConsoleApp1.Models;

namespace ConsoleApp1.Strategies;

public class TextReportStrategy : IReportStrategy
{
    public string Generate(Player player)
    {
        return $"--- RAPORT GRACZA ---\n" +
               $"Gracz: {player.Name}\n" +
               $"Poziom: {player.Level}\n" +
               $"Klasa: {player.CharacterClass}\n" +
               $"Złoto: {player.Gold}\n" +
               $"Osiągnięcia: {player.AchievementsCount}\n" +
               $"---------------------";
    }
}