using PaywallGame.Models;
using PaywallGame.Strategies;

namespace PaywallGame.Services
{
    public class PaywallService
    {
        private readonly IAccessStrategy _strategy;

        public PaywallService(IAccessStrategy strategy)
        {
            _strategy = strategy;
        }

        public bool CheckAccess(Player player)
        {
            return _strategy.CanAccess(player);
        }
    }
}