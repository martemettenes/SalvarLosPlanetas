using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSoundtrack : MonoBehaviour {

    AudioSource rewardSound;


	// Use this for initialization
	void Start () {
        rewardSound = GetComponent<AudioSource>();
	}
}
