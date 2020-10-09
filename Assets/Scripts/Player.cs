using UnityEngine;
using System.Collections;
using System;

public class Player : MonoBehaviour {

    public float speed;
    private Rigidbody2D rigidbody2d;
    private GameObject weapon1;


    // Start is called before the first frame update
    void Start() {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        
        if (Input.GetKeyDown("a")) {
            //rotate the play to face the left 
            if (transform.eulerAngles.z != -180)
                transform.eulerAngles = new Vector3(0, 0, -180);
        }
        if (Input.GetKeyDown("s")) {
            //rotate the play to face the south
            if (transform.eulerAngles.z != -90)
            transform.eulerAngles = new Vector3(0, 0, -90);
        }
        if (Input.GetKeyDown("d")) {
            //rotate the play to face the right
            if (transform.eulerAngles.z != -0)
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetKeyDown("w")) {
            //rotate the play to face the north
            if (transform.eulerAngles.z != 90)
                transform.eulerAngles = new Vector3(0, 0, 90);
        }
    }

    void FixedUpdate() {

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 tempVect = new Vector3(h, v , 0);

        tempVect = tempVect.normalized * speed * Time.deltaTime;
        rigidbody2d.MovePosition(transform.position + tempVect);
    }
}
