using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Healer : Entity.Character
{
    public Healer(string name) : base(name, CharacterClass.Healer)
    {
        Health = 76;
        Strength = 4;
        Intelligence = 19;
        Agility = 15;
        Endurance = 10;
        Luck = 13;
        MainStat = this.Intelligence;
        Atak = MainStat * 3;
        Special = "heal";
    }
}