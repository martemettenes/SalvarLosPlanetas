using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPText : MonoBehaviour {

    public static Text playerHP;

    void Start()
    {
        playerHP = GetComponent<Text>();
    }

    void Update()
    {
        CountingDown();

        if (GameOverText.gameOver == true || WinText.completeLevel == true){
            Destroy(gameObject);
        }
    }

    void CountingDown()
    {
        playerHP.text = "Player HP: " + HealthManagerPlayer.playerHealth;
    }
}
