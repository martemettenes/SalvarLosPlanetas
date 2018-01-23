using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverText : MonoBehaviour {

    public static bool gameOver = false;

    Text text;


	void Start () {
        text = GetComponent<Text>();
	}


    void Update()
    {
        text.text = "";

        if (gameOver == true)
        {
            text.text = "GAME OVER";
            gameOver = true;
        }
            

        if (HealthManagerPlayer.playerHealth <= HealthManagerPlayer.maxPlayerDamage)
        {
            text.text = "GAME OVER";
            gameOver = true;
        }

    }


}
