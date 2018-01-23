using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGravity : MonoBehaviour {

    // Object position
    Vector3 objectPos = new Vector3();

    // Planet position
    Vector3 planetPos = new Vector3();

    Vector2 up, right;

    public Transform planetTrans;
    public bool useRandomPoint = false;

    Rigidbody2D rb;

    public float gravity = 1;
    public float maxVelocity = 1;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        planetTrans = GameObject.Find("Planet").transform;


        if (!useRandomPoint)
            planetPos = planetTrans.position;
        else
            planetPos = Random.insideUnitCircle * 3.5f;
    }

    void FixedUpdate()
    {
        objectPos = transform.position;


        Vector2 dir = planetPos - objectPos;
        dir.Normalize();
        up = -dir;


        if (objectPos.x < planetPos.x)
            transform.rotation = Quaternion.Euler(0, 0, Vector2.Angle(Vector2.up, up));
        else
            transform.rotation = Quaternion.Euler(0, 0, -Vector2.Angle(Vector2.up, up));

        // transform.Translate(dir * .2f);
        // rb.velocity = dir * speed;

        rb.AddForce(dir * gravity);

        // Max Speed
        if (rb.velocity.magnitude > maxVelocity){
            rb.velocity = rb.velocity.normalized * maxVelocity;
        }
    }
}
