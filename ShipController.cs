using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {

    public float horizontalSpeed = 1, verticalSpeed = 0.2f;
    Vector2 input;

    public Transform rootTransform;

    public static int scoreCounter;

    public GameObject happiness;
    public Transform happinessSpawn;

    AudioSource collisionSound;
    AudioSource rewardSound;


    // Countdown to win level after 30 sec
    public static float countDown;

    // Reference to Trampoline Parent (Centerpoint)
    public TrampolineOnOff trampolineParent;

    private void Start()
    {
        countDown = 61.0f;
        scoreCounter = 0;

        collisionSound = GetComponent<AudioSource>();

        //rewardSound = GetComponent<AudioSource>();

    }

    void Update () {



        // Instantiating the countdown
        if (GameOverText.gameOver == false)
            countDown -= Time.deltaTime;


        // Shooting from Spaceship
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(happiness, happinessSpawn.position, happinessSpawn.rotation);
        }

        //Fetching input from controllers
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));


        if (input.x > 0)
            transform.localScale = new Vector3(1, 1, 1);
        else if (input.x < 0)
            transform.localScale = new Vector3(-1, 1, 1);

        // Rotating Centerpoint
        rootTransform.Rotate(Vector3.forward,horizontalSpeed * -input.x * Time.deltaTime);

        // Vertical Movement
        Vector3 pos = transform.localPosition;
        pos += Vector3.up * verticalSpeed * input.y * Time.deltaTime;

        pos = new Vector3(pos.x, Mathf.Clamp(pos.y, 6.0f, 9.5f), pos.z);
        transform.localPosition = pos;
	}


     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Reward")
        {
            print("Sound Reward");

            switch (other.GetComponent<DestroyReward>().rewardType)
            { 
                case DestroyReward.RewardType.Boost:
                    SpeedBoost();

                    Invoke("CancelSpeedBoost", 5);
                    break;
                case DestroyReward.RewardType.Trampoline:
                    trampolineParent.ReviveTrampoline();
                    break;
                default:
                    Debug.LogError("Reward Type Missing");
                    break;
            }
        }

        if (other.tag == "Jerk")
        {
            collisionSound.Play();
            print("Sound");
        }

    }


    // Speedboost for Spaceship when colliding with a spaceboost-icon
    void SpeedBoost()
    {
        horizontalSpeed *= 2;
        verticalSpeed *= 2;
    }

    // Cansel Speedboost, return to normal speed
    void CancelSpeedBoost()
    {
        horizontalSpeed *= .5f;
        verticalSpeed *= .5f;
    }
}
