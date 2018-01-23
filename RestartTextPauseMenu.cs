using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartTextPauseMenu : MonoBehaviour {

    public static int restartText;

    Text restart;



    void Start()
    {
        restart = transform.GetChild(0).GetComponent<Text>();
    }

    void Update()
    {
        
        if (PauseText.paused == true || WinText.completeLevel == true || GameOverText.gameOver == true)
        {
            restart.text = "RESTART";
        }

        else if (PauseText.paused == false)
        {
            restart.text = "";
        }


    }

}
