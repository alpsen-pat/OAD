using PaywallGame.Models;

namespace PaywallGame.Strategies
{
    public interface IAccessStrategy
    {
        bool CanAccess(Player player);
        string GetInfo();
    }
}