﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {


    public static int scoreText;


    Text score;


    void Start()
    {
        score = GetComponent<Text>();
    }

	
	void Update () {
        score.text = "SCORE:" + ShipController.scoreCounter;
	}
}
