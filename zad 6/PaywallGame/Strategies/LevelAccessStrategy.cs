using PaywallGame.Models;

namespace PaywallGame.Strategies
{
    public class LevelAccessStrategy : IAccessStrategy
    {
        private readonly int _requiredLevel;

        public LevelAccessStrategy(int requiredLevel)
        {
            _requiredLevel = requiredLevel;
        }

        public bool CanAccess(Player player)
        {
            return player.Level >= _requiredLevel;
        }

        public string GetInfo()
        {
            return $"Dostęp od poziomu {_requiredLevel}.";
        }
    }
}