using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinText : MonoBehaviour {

    public static bool completeLevel;

    public static Text winText;

    void Start()
    {
        completeLevel = false;

        winText = GetComponent<Text>();
    }


    void Update()
    {

        if (ShipController.countDown <= 1.0f)
        {
            completeLevel = true;
        }

        winText.text = "";

        if (completeLevel == true)
        {
            print("WIN WIN WIN");
            winText.text = "YOU WIN";
            completeLevel = true;
        }

    }



}
