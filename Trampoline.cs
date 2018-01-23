using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {


    public int trampolineLife = 0;

    public int maxLifeTrampoline = 5;
    public GameObject happinessPrefab;

    AudioSource trampolineSound;

    bool isFlashing = false;

    SpriteRenderer sr;

	void Start () {
        trampolineSound = GetComponent<AudioSource>();
        sr = GetComponent<SpriteRenderer>();
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Jerk")
        {
            trampolineSound.Play();
            print("TrampolineSound"); 

            /* Vector2 velocity = other.GetComponent<Rigidbody2D>().velocity *= -1; */

            GameObject happiness = Instantiate(happinessPrefab, other.transform.position, other.transform.rotation);

            /*
            happiness.GetComponent<ObjectGravity>().gravity *= -1;
            happiness.GetComponent<Rigidbody2D>().velocity = velocity;
            */

            Destroy(other.gameObject); 

            trampolineLife++;
            print("Trampoline" + trampolineLife);

            ShipController.scoreCounter++;
        } 
    }


    void TrampolineFlashing()
    {

        if (sr.color == Color.white)
        {
            sr.color = Color.red;
        } else {
            sr.color = Color.white;
        }
    }


    // Update is called once per frame
    void Update () {

        if (trampolineLife >= maxLifeTrampoline)
        {
            gameObject.SetActive(false);
        }

        if (trampolineLife > 3 && isFlashing == false)
        {
            InvokeRepeating("TrampolineFlashing", 0, 0.2f);
            isFlashing = true;
        }

        if (trampolineLife < 4){
            CancelInvoke("TrampolineFlashing");
            isFlashing = false;
            sr.color = Color.white;
        }


        if (GameOverText.gameOver == true || WinText.completeLevel == true)
        {
            gameObject.SetActive(false);
        }
		
	}
}
