using System.Collections;
using System.Collections.Generic;

public class ConsumableWeaponController : WeaponStats {

    private string name;
    private int baseDamage = 1;
    private float damageModifier = 0.01f;
    private float speed = 1; 
    private int strength = 0;
    private int dex = 0;
    private int intelligence = 0;
    private int rarity = 1;//rarity will be 1-5. one is the most common
    private int lowEndDamage;
    private int highEndDamage;


    public string Name { get => name; set => name = value; }
    public int BaseDamage { get => baseDamage; set => baseDamage = value; }
    public float DamageModifier { get => damageModifier; set => damageModifier = value; }
    public float Speed { get => speed; set => speed = value; }
    public int Strength { get => strength; set => strength = value; }
    public int Dex { get => dex; set => dex = value; }
    public int Intelligence { get => intelligence; set => intelligence = value; }
    public int Rarity { get => rarity; set => rarity = value; }
    public int LowEndDamage { get => lowEndDamage; set => lowEndDamage = value; }
    public int HighEndDamage { get => highEndDamage; set => highEndDamage = value; }
}
