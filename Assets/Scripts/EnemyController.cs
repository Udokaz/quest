using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour, CharacterStats {

    private Rigidbody2D rigidbody2d;
    private GameObject weapon1;
    public Text healthText;

    private ConsumableCharacterStats Stats = new ConsumableCharacterStats();

    public int Health { get => Stats.Health; set => Stats.Health = value; }
    public int Strength { get => Stats.Strength; set => Stats.Strength = value; }
    public int Dex { get => Stats.Dex; set => Stats.Dex = value; }
    public int Intelligence { get => Stats.Intelligence; set => Stats.Intelligence = value; }
    public int Armor { get => Stats.Armor; set => Stats.Armor = value; }
    public int Damage { get => Stats.Damage; set => Stats.Damage = value; }
    public float Speed { get => Stats.Speed; set => Stats.Speed = value; }

    // Start is called before the first frame update
    void Start() {
        rigidbody2d = GetComponent<Rigidbody2D>();
        Speed = 2;
        Health = 100;
        Strength = 10;
        Dex = 10;
        Intelligence = 10;
        Armor = 1;
        Damage = 2;
        setHealthText();
    }

    // Update is called once per frame
    void Update() {
        
    }

    private void setHealthText() {
        healthText.text = "Enemy Health: " + Health.ToString();
    }

    public void receiveDamage(int damage) {
        
        Health -= damage;
        if (Health <= 0) {
            Health = 0;
            rigidbody2d.simulated = false;
        }
        setHealthText();
    }
}
