using PaywallGame.Enums;
using PaywallGame.Strategies;

namespace PaywallGame.Factory
{
    public static class AccessStrategyFactory
    {
        public static IAccessStrategy CreateStrategy(AccessType type, int requiredLevel = 0)
        {
            return type switch
            {
                AccessType.Free => new FreeAccessStrategy(),
                AccessType.Premium => new PremiumAccessStrategy(),
                AccessType.Level => new LevelAccessStrategy(requiredLevel),
                _ => throw new ArgumentException("Nieznany typ dostępu")
            };
        }
    }
}