using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Healer : Entity.Character
{
    public Healer(string name) : base(name, CharacterClass.Healer)
    {
        Health = 80;
        Strength = 4;
        Intelligence = 16;
        Agility = 10;
    }
}