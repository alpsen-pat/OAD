using System.Security.Cryptography;
using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Gambler : Entity.Character
{
    public Gambler(string name) : base(name, CharacterClass.Gambler)
    {
        Health = 1;
        Strength = 1;
        Intelligence = 1;
        Agility = 1;
        Endurance = 1;
        Random random = new Random();
        Luck = random.Next(0, 777);
        MainStat = this.Luck;
        Atak = MainStat * 3;
        Special = "jackpot";
    }
}