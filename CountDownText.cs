using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownText : MonoBehaviour {

    public Text countDownText;

    void Start()
    {
        countDownText = GetComponent<Text>();
    }

	void Update () {

        CountingDown();

        if (GameOverText.gameOver == true || WinText.completeLevel == true){
            Destroy(gameObject);
        }
	}

    void CountingDown(){
        
        countDownText.text = "Time Left: " + (int)ShipController.countDown;
    }
}
