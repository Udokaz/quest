using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Player : MonoBehaviour, CharacterStats {

    private Rigidbody2D rigidbody2d;
    private SwordController swordController;
    private int strengthToDamage = 10;
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
        swordController = transform.Find("Sword").GetComponent<SwordController>();
        Health = 100;
        Strength = 10 + swordController.Strength;
        Dex = 10 + swordController.Dex;
        Intelligence = 10 + swordController.Intelligence;
        Armor = 1;
        Damage = setAttackDamage();
        setHealthText();
    }

    private int setAttackDamage() {
        return (int)Math.Floor((double)Strength / strengthToDamage) + Damage;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey("a")) {
            //rotate the play to face the left 
            if (transform.eulerAngles.z != -180 && !Input.GetKey("s") && !Input.GetKey("d") && !Input.GetKey("w"))
                transform.eulerAngles = new Vector3(0, 0, -180);
        }
        if (Input.GetKey("s")) {
            //rotate the play to face the south
            if (transform.eulerAngles.z != -90 && !Input.GetKey("a") && !Input.GetKey("d") && !Input.GetKey("w"))
                transform.eulerAngles = new Vector3(0, 0, -90);
        }
        if (Input.GetKey("d")) {
            //rotate the play to face the right
            if (transform.eulerAngles.z != -0 && !Input.GetKey("s") && !Input.GetKey("a") && !Input.GetKey("w"))
                transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetKey("w")) {
            //rotate the play to face the north
            if (transform.eulerAngles.z != 90 && !Input.GetKey("s") && !Input.GetKey("d") && !Input.GetKey("a"))
                transform.eulerAngles = new Vector3(0, 0, 90);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            swordController.swing();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            swordController.stab();
        }
    }

    void FixedUpdate() {

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 tempVect = new Vector3(h, v , 0);

        tempVect = tempVect.normalized * Speed * Time.deltaTime;
        rigidbody2d.MovePosition(transform.position + tempVect);
    }

    void setHealthText() {
        healthText.text = "Health: " + Health.ToString();
    }
}
