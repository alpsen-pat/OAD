namespace PaywallGame.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public bool IsPremium { get; set; }
        public bool HasDlc { get; set; }
    }
}