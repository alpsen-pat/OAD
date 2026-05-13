using PaywallGame.Models;
using PaywallGame.Enums;
using PaywallGame.Factory;
using PaywallGame.Services;
using PaywallGame.Strategies;

namespace PaywallGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player
            {
                Name = "Jan",
                Level = 10,
                IsPremium = false,
                HasDlc = true
            };

            AccessType type = AccessType.Level;

            IAccessStrategy strategy = AccessStrategyFactory.CreateStrategy(type, requiredLevel: 5);

            var paywallService = new PaywallService(strategy);

            bool canAccess = paywallService.CheckAccess(player);
            
            Console.WriteLine($"Gracz: {player.Name}");
            Console.WriteLine(strategy.GetInfo());
            Console.WriteLine($"Dostęp: {(canAccess ? "TAK" : "NIE")}");
        }
    }
}