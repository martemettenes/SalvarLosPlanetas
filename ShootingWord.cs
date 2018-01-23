using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingWord : MonoBehaviour {

    public float speed = 10;

    Rigidbody2D rb;

    AudioSource shot;

    void Start()
    {
        shot = GetComponent<AudioSource>();

        rb = GetComponent<Rigidbody2D>();
        // up is direction of shot
        rb.velocity = transform.up * speed;

        transform.localScale = Vector3.one * 0.3f;
    }

    private void Update()
    {

        if (transform.localScale != Vector3.one){
            transform.localScale = Vector3.MoveTowards(transform.localScale, Vector3.one, 10 * Time.deltaTime);
        }




    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player"){
            shot.Play();
        }
    }


}
