using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour, WeaponStats {
    
    public Animator animator;

    private ConsumableWeaponController stats = new ConsumableWeaponController();

    public string Name { get => stats.Name; set => stats.Name = value; }
    public int BaseDamage { get => stats.BaseDamage; set => stats.BaseDamage = value; }
    public float DamageModifier { get => stats.DamageModifier; set => stats.DamageModifier = value; }
    public float Speed { get => stats.Speed; set => stats.Speed = value; }
    public int Strength { get => stats.Strength; set => stats.Strength = value; }
    public int Dex { get => stats.Dex; set => stats.Dex = value; }
    public int Intelligence { get => stats.Intelligence; set => stats.Intelligence = value; }
    public int Rarity { get => stats.Rarity; set => stats.Rarity = value; }
    public int LowEndDamage { get => stats.LowEndDamage; set => stats.LowEndDamage = value; }
    public int HighEndDamage { get => stats.HighEndDamage; set => stats.HighEndDamage = value; }

    void Awake() {
        Speed = 1;
        Strength = 1;
        Dex = 1;
        Intelligence = 1;
        Rarity = 1; 
        BaseDamage = 1;
        DamageModifier = 0.1f;
        int modifiedDamage = (int)System.Math.Ceiling(BaseDamage * DamageModifier);
        if (modifiedDamage <= 0)
            modifiedDamage = 1;
        LowEndDamage = (modifiedDamage - BaseDamage);
        HighEndDamage = (modifiedDamage + BaseDamage);
    }

    // Start is called before the first frame update
    void Start() {        
        Name = "Rusty Sword";
    }

    public void swing() {
        animator.SetTrigger("Swing");
    }

    public void stab() {
        animator.SetTrigger("Stab");
    }

    //OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
    void OnTriggerEnter2D(Collider2D other) {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("Enemy")) {
            EnemyController enemy = other.GetComponent<EnemyController>();
            Player player = transform.parent.GetComponent<Player>();
            enemy.receiveDamage(UnityEngine.Random.Range(LowEndDamage + player.Damage, HighEndDamage + player.Damage));
        }
    }
}
