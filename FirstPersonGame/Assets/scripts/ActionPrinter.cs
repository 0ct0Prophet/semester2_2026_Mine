using UnityEngine;

public class ActionPrinter : MonoBehaviour
{
    void Start()
    {
        Warrior warrior = new Warrior("Aragorn", "Sword");
        Debug.Log("Name: " + warrior.Name);
        Debug.Log("Weapon: " + warrior.Weapon);
    }
}
