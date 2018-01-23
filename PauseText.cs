using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseText : MonoBehaviour {
    
    public static bool paused;

    Text pause;


	void Start ()
    {
        pause = GetComponent<Text>();
        paused = false;
	}


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            paused = !paused;
        }

        if (paused == true)
        {
            pause.text = "PAUSE";
            Time.timeScale = 0;
        }

        else
        {
            pause.text = "";
            paused = false;

            Time.timeScale = 1;
        }

    }

}
