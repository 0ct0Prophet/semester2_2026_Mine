using UnityEngine;

public class Sword : Weapon
{
    public Sword(string name, int damage) : base(name, damage)
    {
    }

    public override void Attack()
    {
        Debug.Log(Name + " is attacking with a slash.");
    }
}
