using PaywallGame.Models;

namespace PaywallGame.Strategies
{
    public class DlcAccessStrategy : IAccessStrategy
    {
        public bool CanAccess(Player player)
        {
            return player.HasDlc;
        }

        public string GetInfo()
        {
            return "Dostęp tylko dla graczy posiadających DLC.";
        }
    }
}