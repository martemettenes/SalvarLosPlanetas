using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnTouch : MonoBehaviour {

    Vector3 originalScale;
    float rand;

    private void Start()
    {
        originalScale = transform.localScale;
        rand = Random.Range(0f, 10f);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
        else if (other.tag == "Planet")
        {
            Destroy(gameObject); 
        } 

    }


    private void Update()
    {
        if (GameOverText.gameOver == true || WinText.completeLevel == true)
        {
            Destroy(gameObject);
            print("All enemies destroyed");
        }
            

        if (transform.position.magnitude > 100)
            Destroy(gameObject);

        transform.localScale = new Vector3(
            originalScale.x + Mathf.Sin(rand + Time.time * 2) * .01f,
            originalScale.x + Mathf.Sin(rand + Time.time * 2) * .01f,
            1);
    }

}
