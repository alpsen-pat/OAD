using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Archer : Entity.Character
{
    public Archer(string name) : base(name, CharacterClass.Archer)
    {
        Health = 67;
        Strength = 4;
        Intelligence = 21;
        Agility = 21;
        Endurance = 12;
        Luck = 18;
        MainStat = this.Agility;
        Atak = MainStat * 3;
        Special = "Critical hit";
    }
}