using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    private void Start()
    {
        Sword sword = new Sword("Sword", 20);
        Bow bow = new Bow("Bow", 15);

        List<Weapon> weapons = new List<Weapon>();
        weapons.Add(sword);
        weapons.Add(bow);

        foreach (Weapon weapon in weapons)
        {
            weapon.Attack();
        }
    }
}
