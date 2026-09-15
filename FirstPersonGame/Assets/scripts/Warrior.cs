using UnityEngine;

public class Warrior : Character
{
    public string Weapon { get; private set; }

    public Warrior(string name, string weapon) : base(name)
    {
        Weapon = weapon != null ? weapon.ToLowerInvariant() : null;
    }
}
