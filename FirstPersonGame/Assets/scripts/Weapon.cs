using UnityEngine;

public class Weapon
{
    public string Name { get; set; }
    public int Damage { get; set; }

    public Weapon(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public virtual void Attack()
    {
        Debug.Log(Name + " is attacking.");
    }
}
