using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Tank : Entity.Character
{
    public Tank(string name) : base(name, CharacterClass.Tank)
    {
        Health = 80;
        Strength = 4;
        Intelligence = 16;
        Agility = 10;
    }
}