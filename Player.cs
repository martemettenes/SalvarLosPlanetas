using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Player position
    Vector3 pPos = new Vector3();

    // Planet position
    Vector3 oPos = new Vector3();

    Vector2 up;

    public Transform planetTrans;

    Rigidbody2D rb;

    public float gravity = 1;
    public float playerSpeed = 1;


	void Start () {

        rb = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () {

        oPos = planetTrans.position;
        pPos = transform.position;
       

        Vector2 dir = oPos - pPos;
        dir.Normalize();
        up = -dir;



        if (pPos.x < oPos.x)
            transform.rotation = Quaternion.Euler(0, 0, Vector2.Angle(Vector2.up, up));
        else
            transform.rotation = Quaternion.Euler(0, 0, -Vector2.Angle(Vector2.up, up));



        //Debug.DrawLine(pPos, pPos + dir * 2, Color.red);

        // transform.Translate(dir * .2f);

        // rb.velocity = dir * speed;

        rb.AddForce(dir * gravity);



        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector3(moveHorizontal, 0);

        rb.AddRelativeForce(movement * playerSpeed);



	}
}
