using PaywallGame.Models;

namespace PaywallGame.Strategies
{
    public class PremiumAccessStrategy : IAccessStrategy
    {
        public bool CanAccess(Player player)
        {
            return player.IsPremium;
        }

        public string GetInfo()
        {
            return "Dostęp tylko dla graczy premium.";
        }
    }
}