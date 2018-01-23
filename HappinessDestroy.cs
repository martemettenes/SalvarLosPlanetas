using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappinessDestroy : MonoBehaviour {

    void DestroyGameObject()
    {
        Destroy(gameObject);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Jerk")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            ShipController.scoreCounter++;

            print("Score" + ShipController.scoreCounter); 
        }
        else
        {
            Invoke("DestroyGameObject", 5);
        }
    }



}
