using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitTextPauseMenu : MonoBehaviour {

    public static int quitText;

    Text quit;

    void Start()
    {
        quit = GetComponent<Text>();
    }


    void Update()
    {

        if (PauseText.paused == true || WinText.completeLevel == true || GameOverText.gameOver == true)
        {
            quit.text = "QUIT";
        }

        else if (PauseText.paused == false)
        {
            quit.text = "";
        }

    }
}
