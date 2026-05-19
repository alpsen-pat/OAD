using System;
using ConsoleApp1.Enums;
using ConsoleApp1.Facades;
using ConsoleApp1.Models;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Player toxicPlayer = new Player
        {
            Name = "Skibidi67",
            Level = 42,
            CharacterClass = "Wojownik",
            Gold = 2500,
            AchievementsCount = 12
        };

        ReportFacade facade = new ReportFacade();

        Console.WriteLine("=== SYSTEM RAPORTOWANIA INICJOWANY ===\n");

        Console.WriteLine("Generowanie raportu tekstowego...");
        facade.GenerateAndSave(toxicPlayer, ReportType.Text);

        Console.WriteLine("Generowanie raportu JSON...");
        facade.GenerateAndSave(toxicPlayer, ReportType.Json);

        Console.WriteLine("Generowanie raportu CSV...");
        facade.GenerateAndSave(toxicPlayer, ReportType.Csv);

        Console.WriteLine("Wszystkie raporty zostały przetworzone.");
        Console.ReadKey();
    }
}