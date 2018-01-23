using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManagerPlanet : MonoBehaviour {

    public static int planetHealth;
    int maxPlanetDamage = 10;

    public static bool planetSad;

    public Animator anim;
    public Animator trampolineAnim;

    AudioSource collisionSound;

    private void Start()
    {
        planetSad = false;
        planetHealth = 0;

        collisionSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        anim.SetInteger("Health", planetHealth);

        if (trampolineAnim.gameObject.activeSelf)
        trampolineAnim.SetInteger("Health", planetHealth);

        if (WinText.completeLevel == true)
        {
            planetHealth = 0;
        }

        if (GameOverText.gameOver == true){
            planetHealth = 10;
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Jerk")
        {
            collisionSound.Play();
            planetHealth++;
            print(planetHealth);
        }


        if (planetHealth >= maxPlanetDamage)
        {
            print("Planet died");
            GameOverText.gameOver = true;
        }


    }

}
