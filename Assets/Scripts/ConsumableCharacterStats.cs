using System.Collections;
using System.Collections.Generic;

//Class that will be the base for players and npcs
public class ConsumableCharacterStats : CharacterStats {

    private int health = 100;
    private int strength = 10;
    private int dex = 10;
    private int intelligence = 10;
    private int armor = 0;
    private int damage = 1;
    private float speed = 1;

    public int Health { get => health; set => health = value; }
    public int Strength { get => strength; set => strength = value; }
    public int Dex { get => dex; set => dex = value; }
    public int Intelligence { get => intelligence; set => intelligence = value; }
    public int Armor { get => armor; set => armor = value; }
    public int Damage { get => damage; set => damage = value; }
    public float Speed { get => speed; set => speed = value; }
}
