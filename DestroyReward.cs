using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyReward : MonoBehaviour {

    public enum RewardType { Boost, Trampoline };
    public RewardType rewardType = RewardType.Boost;

    SpriteRenderer sr;

    Vector3 originalScale;
    float rand;

    private void Start()
    {
        originalScale = transform.localScale;
        rand = Random.Range(0f, 10f);


        sr = GetComponent<SpriteRenderer>();
    }


    void Update()
    {

        transform.localScale = new Vector3(
    originalScale.x + Mathf.Sin(rand + Time.time * 4) * 0.05f,
    originalScale.x + Mathf.Cos(rand + Time.time * 4) * 0.05f,
    1);



        //Destroy gameobject(reward) if it's game over
        if (GameOverText.gameOver == true || WinText.completeLevel == true)
        {
            Destroy(gameObject);
        }


        // Destroy gameobject(reward) after 5 sec
        Destroy(gameObject, 5);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player"){
            GetComponent<AudioSource>().Play();
            Invoke("DestroyMe", 3);
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
        }
    }

    void DestroyMe(){
        Destroy(gameObject);
    }

}
