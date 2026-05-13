using PaywallGame.Models;

namespace PaywallGame.Strategies
{
    public class FreeAccessStrategy : IAccessStrategy
    {
        public bool CanAccess(Player player)
        {
            return true;
        }

        public string GetInfo()
        {
            return "Dostęp darmowy dla każdego.";
        }
    }
}