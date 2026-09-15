using UnityEngine;

public class Bow : Weapon
{
    public Bow(string name, int damage) : base(name, damage)
    {
    }

    public override void Attack()
    {
        Debug.Log(Name + " is attacking with an arrow shot.");
    }
}
