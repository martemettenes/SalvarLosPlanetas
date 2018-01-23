using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineOnOff : MonoBehaviour {


    GameObject child;


	void Start () {

        child = transform.GetChild(0).gameObject;

        child.SetActive(false);
	}
	

    public void ReviveTrampoline()
    {
        child.SetActive(true);
        child.GetComponent<Trampoline>().trampolineLife = 0;

        print("THE TRAMPOLINE IS ALIVE");

    }
}
