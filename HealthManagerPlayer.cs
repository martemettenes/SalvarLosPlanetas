using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManagerPlayer : MonoBehaviour {


    public static int playerHealth;
    public static int maxPlayerDamage = 0;

    private void Start()
    {
        playerHealth = 5;
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Jerk"){
            playerHealth--;
            print("Player has been damaged " + playerHealth);
        }


        if (playerHealth == maxPlayerDamage){
            print("Game Over");
        }

    }
}
