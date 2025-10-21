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
        Luck = 777;
        Main_stat = 777;
    }
}